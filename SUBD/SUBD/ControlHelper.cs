using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public static class ControlHelper
    {
        public static bool IsFormValid<T>(this T view)
        {
            var type = view.GetType();

            var fields = type.GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Instance);

            bool isValid = true;

            foreach (var fieldInfo in fields
                .Where(x => x.FieldType == (typeof(TextEdit))))
            {
                var method = fieldInfo.FieldType.GetMethod("IsValid");
                var value = ReflectionHelper.GetPropertyOrFieldValue(view, fieldInfo.AsEnumerable());

                var obj = method.Invoke(value, null);

                isValid = isValid && (bool)obj;

            }
            return isValid;
        }

        public static bool IsNullOrEmpty(this string x)
        {
            return string.IsNullOrEmpty(x);
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public class PasswordHelper
    {
        public static string GetHash(string password)
        {
            byte[] salt;
            byte[] buffer2;
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }

        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[0x10];
            Buffer.BlockCopy(src, 1, dst, 0, 0x10);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return AreHashesEqual(buffer3, buffer4);
        }

        private static bool AreHashesEqual(byte[] firstHash, byte[] secondHash)
        {
            int _minHashLength = firstHash.Length <= secondHash.Length ? firstHash.Length : secondHash.Length;
            var xor = firstHash.Length ^ secondHash.Length;
            for (int i = 0; i < _minHashLength; i++)
                xor |= firstHash[i] ^ secondHash[i];
            return 0 == xor;
        }
    }

    public class ReflectionHelper
    {

        public static object GetPropertyOrFieldValue(object entity, IEnumerable<MemberInfo> path)
        {
            object value = entity;

            foreach (MemberInfo memberInfo in path)
            {
                if (value == null)
                    throw new ApplicationException(string.Format("can't get property: null on the path {0}", memberInfo.Name));

                if (memberInfo is FieldInfo)
                    value = (memberInfo as FieldInfo).GetValue(value);
                else if (memberInfo is PropertyInfo)
                {
                    var propertyInfo = (memberInfo as PropertyInfo);
                    if (!propertyInfo.CanRead)
                        throw new ApplicationException("Property has no getter");

                    value = propertyInfo.GetValue(value, new object[0]);
                }
                else
                    throw new ApplicationException("Unsupported memberinfo type");
            }

            return value;
        }

        public static List<MemberInfo> GetMemberInfoPath(LambdaExpression entityProperty)
        {
            var result = new List<MemberInfo>();
            Expression current = entityProperty.Body;

            while (current.NodeType == ExpressionType.Convert || current.NodeType == ExpressionType.MemberAccess) //up from inner properties to source entity
            {
                if (current.NodeType == ExpressionType.Convert)
                {
                    current = ((UnaryExpression)current).Operand;
                }
                else if (current.NodeType == ExpressionType.MemberAccess)
                {
                    result.Add((current as MemberExpression).Member);
                    current = (current as MemberExpression).Expression;
                }
                else
                    throw new ArgumentException("Not a member access", "expression");
            }

            result.Reverse();

            if (!(current is ParameterExpression) || result.Count == 0)
                throw new ApplicationException("linq выражение должно состоять из вызова свойства у параметра");

            return result;
        }
    }

    public static class MayBe
    {
        public static IEnumerable<T> AsEnumerable<T>(this T self)
        {
            yield return self;
        }

        public static TResult With<TInput, TResult>(this TInput input, Func<TInput, TResult> evaluatingFunc)
            where TInput : class
            where TResult : class
        {
            if (input == null)
                return null;

            return evaluatingFunc(input);
        }
    }
}
