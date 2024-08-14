LinqQueries queries = new LinqQueries();

//ImprimirValores(queries.TodaLaColecion());

//Where
//ImprimirValores(queries.LibrosDespuesdel2000());

//Where And
//ImprimirValores(queries.LibrosConMAsde250PagConPalabraInAction());

//All
//Console.WriteLine($"Todos los libros tienen Status?: {queries.TodosLosLibrosTienenStatus()}");

//Any
//Console.WriteLine($"Algun Libro Fue Publicado En 2005?: {queries.AlgunLibroFuePublicadoEn2005()}");

//Contains
//ImprimirValores(queries.LibrosDePython());

//OrderBy
//ImprimirValores(queries.LibrosDeJavaPorNombreAscendente());

//OrderByDescending
//ImprimirValores(queries.LibrosConMasDe450PaginasDesen());

//Take
//ImprimirValores(queries.TresPrimerosLibrosOrdenadosPorFecha());

//Skip
//ImprimirValores(queries.TercerYCuartoLibroDeMas400Pag());

//filtroSelect
ImprimirValores(queries.TresPrimerosLibrosDeLaColeccion());


void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1,15} {2,15}\n","Title","N. Paginas","Fecha publicacion");
    foreach(var item in listadelibros )
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}
