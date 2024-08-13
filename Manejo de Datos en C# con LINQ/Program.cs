LinqQueries queries = new LinqQueries();

//ImprimirValores(queries.TodaLaColecion());

//Where
//ImprimirValores(queries.LibrosDespuesdel2000());

//Where And
ImprimirValores(queries.LibrosConMAsde250PagConPalabraInAction());

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1,15} {2,15}\n","Title","N. Paginas","Fecha publicacion");
    foreach(var item in listadelibros )
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}
