# Dotnet Code format
✅ DO format your code and must follow same pattern for a single team.  
✅ DO use indentation  
✅ DO use tab for indentation  

✅ DO use format before save your file.  
✅ DO use empty new line before your return block.  
✅ DO use format tool. eg. Visual Studio formatter, dotnet formatter  
✅ DO use max 80/120 character length for your line margin.  
✅ DO use break your code whenever your line margin exceeds.  
✅ DO use break your code properly, not partially.  


❌ DO not use extra whitespace.  
❌ DO not use multiple empty line in your code.  
❌ DO not break your code in any place
❌ DO not use alignment without tab indentation  

```cs
namespace MyApp.Core
{
  public class OrderRepository: Repository<Order>, IOrderRepository { 
    
    private readonly OrderDbContext _dbContext;
    private readonly IEvent _event;
    private readonly ILogger _logger;

    public OrderRepository(OrderDbContext dbContext,
        IEvent event,
        ILogger logger) : base(dbContext)
    {
      _dbContext = dbContext;
      _event = event;
      _logger = logger;
    }

    public virtual async Task<<OrderInformationVm>> GetOrderInfoAsync(string orderNumber)
    {
        if (orderGuid == null)
            return null;

        var orderInformation = await _dbContext.Orders
            .Include(o => o.OrderItems).ThenInclude(oi => oi.Products)
            .Select(o => new OrderInformationVm{
                OrderNumber = o.OrderNumber,
                OrderItems = o.OrderItems.Select(oi => new OrderItemInformationVm{
                   OrderId = oi.OrderId,
                   ProductName = oi.Product.Name,
                   Sku = oi.Product.Sku
                }).ToList()
            }).FirstOrDefaultAsync(o => o.OrderNumber = orderNumber);

        return orderInformation;
    }

    public virtual async Task<Order> GetOrderByOrderItemAsync(int orderItemId)
    {
        if (orderItemId == 0)
            return null;

        return await (from o in _dbContext.Orders
            join oi in _dbContext.OrderItems on o.Id equals oi.OrderId
            where oi.Id == orderItemId
            select o).FirstOrDefaultAsync();
    }
  }
}
```