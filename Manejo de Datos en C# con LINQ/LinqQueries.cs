using System.Reflection.Metadata;

public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();
    public LinqQueries()
    {
        using(StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() {PropertyNameCaseInsensitive = true});
        }
    }

    public IEnumerable<Book> TodaLaColecion()
    {
        return librosCollection;
    }

    public IEnumerable<Book> LibrosDespuesdel2000()
    {
        //extension method
        //return librosCollection.Where(p=>p.PublishedDate.Year >2000);

        //query expresion
        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
    }

    public IEnumerable<Book> LibrosConMAsde250PagConPalabraInAction()
    {
        //extension method
        //return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));

        //query expresion
        return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
    }

    public bool TodosLosLibrosTienenStatus()
    {
        return librosCollection.All(p => p.Status!= string.Empty);
    }

    public bool AlgunLibroFuePublicadoEn2005()
    {
        return librosCollection.Any(p => p.PublishedDate.Year == 2005);
    }

    public IEnumerable<Book> LibrosDePython()
    {
        return librosCollection.Where(p => p.Categories.Contains("Python"));
    }

    public IEnumerable<Book> LibrosDeJavaPorNombreAscendente()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
    }

    public IEnumerable<Book> LibrosConMasDe450PaginasDesen()
    {
        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
    }

    public IEnumerable<Book> TresPrimerosLibrosOrdenadosPorFecha()
    {
        return librosCollection
        .Where(p => p.Categories.Contains("Java"))
        .OrderByDescending(p => p.PublishedDate)
        .Take(3);
    }

    public IEnumerable<Book> TercerYCuartoLibroDeMas400Pag()
    {
        return librosCollection
        .Where(p => p.PageCount > 400)
        .Take(4)
        .Skip(2);
    }

    public IEnumerable<Book> TresPrimerosLibrosDeLaColeccion()
    {
        return librosCollection.Take(3)
        .Select(p => new Book() {Title = p.Title, PageCount = p.PageCount});
    }

    public int CantiddLibros200y500Pag()
    {
        return librosCollection.Where(p => p.PageCount>=200 && p.PageCount <= 500).Count();
    }

    public long CantiddLibros200y500PagLong()
    {
        return librosCollection.LongCount(p => p.PageCount>=200 && p.PageCount <= 500);
    }

    public DateTime FechaPublicacionMenor()
    {
        return librosCollection.Min(p => p.PublishedDate);
    }

    public int NumeroPaginasLibroMayor()
    {
        return librosCollection.Max(p => p.PageCount);
    }

}