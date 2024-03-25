namespace Services.CrossCutting
{
    public static class DtoConverter
    {
        public static TSaida Converter<TEntrada, TSaida>(TEntrada entrada)
         where TEntrada : class
         where TSaida : class, new()
        {
            var saida = new TSaida();

            foreach (var e in typeof(TEntrada).GetProperties())
            {
                var propSaida = typeof(TSaida).GetProperty(e.Name);

                if (propSaida != null && propSaida.PropertyType == e.PropertyType)
                {
                    propSaida.SetValue(saida, e.GetValue(entrada));
                }
            }

            return saida;
        }
    }
}
