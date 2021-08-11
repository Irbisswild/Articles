using AutoMapper;

namespace Articles.Services.DAL.Mapping
{
    public static class Mapper
    {
        private static readonly IMapper Instance;

        static Mapper()
        {
            var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<ArticleProfile>();
                    cfg.AddProfile<CommentProfile>();
                }
            );

            Instance = config.CreateMapper();
        }

        /// <summary>
        /// Map
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDest"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static TDest Map<TSource, TDest>(TSource source)
        {
            return Instance.Map<TSource, TDest>(source);
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDest"></typeparam>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        /// <returns></returns>
        public static TDest Update<TSource, TDest>(TSource source, TDest dest)
        {
            return Instance.Map(source, dest);
        }
    }
}
