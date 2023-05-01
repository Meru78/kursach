using kursach.DBManager.Models.ItemModels;

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

        public Task<Supply> GetSupplyAsync(int id)
        {
            var result = _context.Supplys.Where(row => row.SupplyId == id).FirstOrDefault();

            return Task.FromResult(result);
        }

        public int CreateSupply(Supply supply) 
        {
            _context.Supplys.Add(supply);
            _context.SaveChanges();

            return supply.SupplyId;
        }

        public void DeleteSupply(int id)
        {
            var item = _context.Supplys.Where(row => row.SupplyId == id).FirstOrDefault();
            _context.Supplys.Remove(item);
            _context.SaveChanges();
        }
        public void UpdateSupply(Supply supply)
        {
            var item = _context.Supplys.Where(row => row.SupplyId == supply.SupplyId).FirstOrDefault();

            item.SupplyDate = supply.SupplyDate;
            item.Summ = supply.Summ;
            item.Done = supply.Done;

            _context.SaveChanges();
        }
    }
}
