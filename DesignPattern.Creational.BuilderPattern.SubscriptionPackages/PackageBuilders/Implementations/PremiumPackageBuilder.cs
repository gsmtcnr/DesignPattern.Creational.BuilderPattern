namespace DesignPattern.Creational.BuilderPattern.SubscriptionPackages.PackageBuilders
{
    public class PremiumPackageBuilder : BasePackageBuilder, IPackageBuilder
    {
        public override void SetUnitPrice(decimal val)
        {
            //I manipulate the Unit Price value by calculation
            base.SetUnitPrice(val);  
            if (Package.Contacts > 0 && Package.UnitPrice > 0)
            {
                var x = Package.Contacts / 1000;
                var y = Package.UnitPrice * x;
                var z = y - 1;
                Package.SetUnitPrice(decimal.Round(z, 2));
            }
        }
    }
}
