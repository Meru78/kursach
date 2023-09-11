namespace kursach.DBManager.Models.SellsModels
{
    public class SellsController
    {
        public SellsController(DBManager context)
        {
            _context = context;
        }

        DBManager _context;

        public Task<Sells[]> GetSells()
        {
            var result = _context.SellsItem.ToArray();
            return Task.FromResult(result);
        }

        public Task<Sells[]> GetSellsByClient(string FIO)
        {
            var result = _context.SellsItem.Where(row => row.user.FIO == FIO).ToArray();
            return Task.FromResult(result);
        }
        public void CreateSells(Sells sells)
        {
            _context.SellsItem.Add(sells);
            _context.SaveChanges();
        }
        public void DeleteSell(Sells sells)
        {
            _context.SellsItem.Remove(sells);
            _context.SaveChanges();
        }
    }
}
