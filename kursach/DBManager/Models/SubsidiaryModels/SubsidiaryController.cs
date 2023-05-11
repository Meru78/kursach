namespace kursach.DBManager.Models.SubsidiaryModels
{
    public class SubsidiaryController
    {
        public SubsidiaryController(DBManager context)
        {
            _context = context;
        }

        DBManager _context;

        public Task<List<Subsidiary>> GetSubsidiaryAsync()
        {
            var result = _context.Subsidiaries.ToList();
            return Task.FromResult(result);
        }
    }
}
