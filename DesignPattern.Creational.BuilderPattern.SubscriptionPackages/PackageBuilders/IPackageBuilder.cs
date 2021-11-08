using DesignPattern.Creational.BuilderPattern.SubscriptionPackages.Models;

namespace DesignPattern.Creational.BuilderPattern.SubscriptionPackages.PackageBuilders
{
    public interface IPackageBuilder
    {
        void Reset();
        SubscriptionPackage Build();
        void SetIsAPIAccess(bool val);
        void SetAPILimits(string val);
        void SetIsDigitalMembership(bool val);
        void SetIsMultipleBankAccount(bool val);
        void SetPackageType(PackageType packageType);
        void SetDurationType(DurationType durationType);
        void SetUnitPrice(decimal val);
        void SetStorage(string val);
        void SetAdminCount(int val);
        void SetContactCount(int val);
        void SetPaymentTransactionRate(decimal val);
        void SetPaymentTransactionPrice(decimal val);
        void SetEmailSenderCount(int val);
    }
}
