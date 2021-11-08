using DesignPattern.Creational.BuilderPattern.SubscriptionPackages.Constants;
using DesignPattern.Creational.BuilderPattern.SubscriptionPackages.Models;

namespace DesignPattern.Creational.BuilderPattern.SubscriptionPackages.PackageBuilders
{
    public abstract class BasePackageBuilder : IPackageBuilder
    {
        public SubscriptionPackage Package;
        public BasePackageBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            Package = SubscriptionPackage.Create();
        }

        public SubscriptionPackage Build()
        {
            CalcTotalPrice();
            SubscriptionPackage tempPackage = Package;
            Reset();
            return tempPackage;
        }
        public void CalcTotalPrice()
        {
            decimal totalPrice = decimal.Zero;

            if (Package.UnitPrice > 0)
            {
                totalPrice = decimal.Round(Package.UnitPrice * IntVariables.TotalMonth, 2);
            }

            Package.SetTotalPrice(totalPrice);
        }

        #region Set Methods

        public void SetAdminCount(int val)
        {
            Package.SetAdminCount(val);
        }

        public void SetAPILimits(string val)
        {
            Package.SetAPILimits(val);
        }

        public void SetContactCount(int val)
        {
            Package.SetContactCount(val);
        }

        public void SetDigitalMembership(bool val)
        {
            Package.SetIsDigitalMembership(val);
        }

        public void SetDurationType(DurationType durationType)
        {
            Package.SetDurationType(durationType);
        }

        public void SetEmailSenderCount(int val)
        {
            Package.SetEmailSenderCount(val);
        }

        public void SetIsAPIAccess(bool val)
        {
            Package.SetIsAPIAccess(val);
        }

        public void SetIsDigitalMembership(bool val)
        {
            Package.SetIsDigitalMembership(val);
        }

        public void SetIsMultipleBankAccount(bool val)
        {
            Package.SetIsMultipleBankAccount(val);
        }

        public void SetPackageType(PackageType val)
        {
            Package.SetPackageType(val);
        }

        public void SetPaymentTransactionPrice(decimal val)
        {
            Package.SetPaymentTransactionPrice(val);
        }

        public void SetPaymentTransactionRate(decimal val)
        {
            Package.SetPaymentTransactionRate(val);
        }

        public void SetStorage(string val)
        {
            Package.SetStorage(val);
        }

        public virtual void SetUnitPrice(decimal val)
        {
            Package.SetUnitPrice(val);
        }

        #endregion
    }
}
