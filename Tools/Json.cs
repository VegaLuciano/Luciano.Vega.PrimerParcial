using Newtonsoft.Json;

namespace Tools
{
    public static class Json
    {
        public static List<T>? LeerArchivo<T>(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();

                List<T>? lista = JsonConvert.DeserializeObject<List<T>>(json);

                return lista;
            }

        }

        public static void GuardarArchivo<T>(string path, List<T> lista) 
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
            }
        }
    }
}