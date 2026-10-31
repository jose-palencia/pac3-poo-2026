namespace Project01.IntroductionCSharp.ArraysLists
{
    public class Lists
    {
        public void Products()
        {
            List<string> products = new List<string>();

            products.Add("Semitas");
            products.Add("Café");
            products.Add("Galletas");
            products.Insert(0, "Azúcar");
            products.Insert(2, "Chocolate");
            //products.Remove("Galletas");
            //products.RemoveAt(0);

            products.Sort();
            products.Reverse();
            //products.Clear();

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            //products.Contains("Semitas");
            Console.WriteLine($"Total de productos: {products.Count}");
        }
    }
}

/**
LISTA DE COMPRAS
1. Agregar
2. Ver Lista
3. Eliminar
4. Salir

*/