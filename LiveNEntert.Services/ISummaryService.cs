using LiveNEntert.Domain;

namespace LiveNEntert.Services
{
    public interface ISummaryService
    {
        Summary GetSummary(int a, int b, Summary summary);
    }
}
