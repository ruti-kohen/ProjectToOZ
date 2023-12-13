using ProjectToOZ.Models;

namespace ProjectToOZ.BLL
{
    public interface ICandidateService
    {
        Task<string> GetCandidatesAsync();
        Task<List<Candidate>> GetCandidatesAsyncList();
    }
}