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
        public void CreateSells(Sells sells)
        {
            _context.SellsItem.Add(sells);
            _context.SaveChanges();
        }
    }
}
