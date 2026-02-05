namespace CalcAppAPI.Application.Services.Pdf.Mapping
{
    public interface IPropertyDisplayNameResolver
    {
        string Resolve(string propertyName);
    }
}
