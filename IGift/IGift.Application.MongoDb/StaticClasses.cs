namespace IGift.Application.MongoDb
{
    public static class Objects
    {
        public static FilterDefinition<T> BuildFilterFromObject<T>(this T filterModel) where T : MongoDbEntity<string>
        {
            var builder = Builders<T>.Filter;
            var filters = new List<FilterDefinition<T>>();

            foreach (var prop in typeof(T).GetProperties())
            {
                var value = prop.GetValue(filterModel);
                if (value != null)
                {
                    filters.Add(builder.Eq(prop.Name, value));
                }
            }

            return filters.Any() ? builder.And(filters) : builder.Empty;
        }
    }

}
