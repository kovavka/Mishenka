//using Persis.NHibernate;
//using Persis.Presentation.Mapping;
//using Persis.UICommon;


//namespace Infrastucture
//{
//    namespace Costs.Infrastructure.Mappings
//    {
//        public class UserMap : VersionedClassMap<User>
//        {
//            public UserMap()
//            {
//                Not.LazyLoad();
//                Map(x => x.Login).Unique();
//                Map(x => x.Password).Nullable();
//                Map(x => x.Rights);
//            }
//        }
        
//        public class UserUiMapper : UIMapper<User>
//        {
//            public UserUiMapper(IUserMappingView view)
//            {
//                Bind(x => x.Login, view.Login);
//                Bind(x => x.Password, view.Password);
//                Bind(x => x.Rights, view.Rights);
//            }
//        }
//    }
//}
