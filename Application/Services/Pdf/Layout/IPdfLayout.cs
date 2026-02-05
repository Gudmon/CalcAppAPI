using QuestPDF.Infrastructure;

namespace CalcAppAPI.Application.Services.Pdf.Layout
{
    public interface IPdfLayout<TModel>
    {
        void ComposeHeader(IContainer container, TModel model, string name);
        void ComposeContent(IContainer container, TModel model, string name);
        void ComposeFooter(IContainer container);
    }
}
