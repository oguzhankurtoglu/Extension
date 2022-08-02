namespace Collectible
{
   public class Collectible : CollectibleBase
   {
      public override void Collect(Collector collector)
      {
         base.Collect(collector);
      
         // Increase coin or collectible count
         Destroy(gameObject);
      }
   }
}
