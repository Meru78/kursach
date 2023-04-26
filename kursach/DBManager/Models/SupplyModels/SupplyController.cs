namespace kursach.DBManager.Models.SupplyModels
{
    public class SupplyController
    {
        public SupplyController(DBManager context)
        {
            _context = context;
        }

        DBManager _context;

        public Task<Supply[]> GetSuppliesAsync()
        {
            var result = _context.Supplys.ToArray();

            return Task.FromResult(result);
        }
    }
}
