using DesignPattern.Creational.BuilderPattern.SubscriptionPackages.Models;
using DesignPattern.Creational.BuilderPattern.SubscriptionPackages.PackageBuilders;

namespace DesignPattern.Creational.BuilderPattern.SubscriptionPackages
{
    public class PackageDirector
    {
        private IPackageBuilder _packageBuilder;
        public void SetBuilder(IPackageBuilder packageBuilder)
        {
            _packageBuilder = packageBuilder;
        }

        #region Free

        public SubscriptionPackage BuildFreeMonthlyPackage()
        {
            _packageBuilder.SetDurationType(DurationType.Monthly);
            _packageBuilder.SetPackageType(PackageType.Free);
            _packageBuilder.SetContactCount(50);
            _packageBuilder.SetStorage("0.25 GB");
            _packageBuilder.SetAdminCount(1);
            _packageBuilder.SetPaymentTransactionRate(4);
            _packageBuilder.SetPaymentTransactionPrice(0.6M);
            return _packageBuilder.Build();
        }

        public SubscriptionPackage BuildFreeYearlyPackage()
        {
            _packageBuilder.SetDurationType(DurationType.Yearly);
            _packageBuilder.SetPackageType(PackageType.Free);
            _packageBuilder.SetContactCount(50);
            _packageBuilder.SetStorage("0.25 GB");
            _packageBuilder.SetAdminCount(1);
            _packageBuilder.SetPaymentTransactionRate(4);
            _packageBuilder.SetPaymentTransactionPrice(0.6M);
            return _packageBuilder.Build();
        }

        #endregion

        #region Essentials

        public SubscriptionPackage BuildEssentialsMonthlyEssentials()
        {
            _packageBuilder.SetDurationType(DurationType.Monthly);
            _packageBuilder.SetPackageType(PackageType.Essentials);
            _packageBuilder.SetContactCount(1000);
            _packageBuilder.SetUnitPrice(59);
            _packageBuilder.SetStorage("0.5 GB");
            _packageBuilder.SetAdminCount(1);
            _packageBuilder.SetPaymentTransactionRate(2);
            _packageBuilder.SetPaymentTransactionPrice(0.6M);
            _packageBuilder.SetEmailSenderCount(1);
            return _packageBuilder.Build();
        }

        public SubscriptionPackage BuildEssentialsYearlyEssentials()
        {
            _packageBuilder.SetDurationType(DurationType.Yearly);
            _packageBuilder.SetPackageType(PackageType.Essentials);
            _packageBuilder.SetContactCount(1000);
            _packageBuilder.SetUnitPrice(49);
            _packageBuilder.SetStorage("0.5 GB");
            _packageBuilder.SetAdminCount(1);
            _packageBuilder.SetPaymentTransactionRate(2);
            _packageBuilder.SetPaymentTransactionPrice(0.6M);
            _packageBuilder.SetEmailSenderCount(1);
            return _packageBuilder.Build();
        }

        #endregion

        #region Professional

        public SubscriptionPackage BuildProfessionalMonthlyEssentials()
        {

            _packageBuilder.SetDurationType(DurationType.Monthly);
            _packageBuilder.SetPackageType(PackageType.Professional);
            _packageBuilder.SetContactCount(2000);
            _packageBuilder.SetUnitPrice(119);
            _packageBuilder.SetStorage("1 GB");
            _packageBuilder.SetAdminCount(2);
            _packageBuilder.SetPaymentTransactionRate(1.5M);
            _packageBuilder.SetPaymentTransactionPrice(0.6M);
            _packageBuilder.SetEmailSenderCount(2);
            _packageBuilder.SetIsDigitalMembership(true);
            _packageBuilder.SetIsMultipleBankAccount(true);
            return _packageBuilder.Build();
        }

        public SubscriptionPackage BuildProfessionalYearlyEssentials()
        {


            _packageBuilder.SetDurationType(DurationType.Yearly);
            _packageBuilder.SetPackageType(PackageType.Professional);
            _packageBuilder.SetContactCount(2000);
            _packageBuilder.SetUnitPrice(99);
            _packageBuilder.SetStorage("1 GB");
            _packageBuilder.SetAdminCount(2);
            _packageBuilder.SetPaymentTransactionRate(1.5M);
            _packageBuilder.SetPaymentTransactionPrice(0.6M);
            _packageBuilder.SetEmailSenderCount(2);
            _packageBuilder.SetIsDigitalMembership(true);
            _packageBuilder.SetIsMultipleBankAccount(true);
            return _packageBuilder.Build();

        }

        #endregion

        #region Premium

        public SubscriptionPackage BuildPremiumMonthlyEssentials(int contactCount = 5000)
        {

            _packageBuilder.SetDurationType(DurationType.Monthly);
            _packageBuilder.SetPackageType(PackageType.Premium);
            _packageBuilder.SetContactCount(contactCount);
            _packageBuilder.SetUnitPrice(50);
            _packageBuilder.SetStorage("4 GB");
            _packageBuilder.SetAdminCount(5);
            _packageBuilder.SetPaymentTransactionRate(1.0M);
            _packageBuilder.SetPaymentTransactionPrice(0.6M);
            _packageBuilder.SetEmailSenderCount(5);
            _packageBuilder.SetIsDigitalMembership(true);
            _packageBuilder.SetIsMultipleBankAccount(true);
            return _packageBuilder.Build();
        }

        public SubscriptionPackage BuildPremiumYearlyEssentials(int contactCount = 5000)
        {


            _packageBuilder.SetDurationType(DurationType.Yearly);
            _packageBuilder.SetPackageType(PackageType.Premium);
            _packageBuilder.SetContactCount(contactCount);
            _packageBuilder.SetUnitPrice(40);
            _packageBuilder.SetStorage("4 GB");
            _packageBuilder.SetAdminCount(5);
            _packageBuilder.SetPaymentTransactionRate(1.0M);
            _packageBuilder.SetPaymentTransactionPrice(0.6M);
            _packageBuilder.SetEmailSenderCount(5);
            _packageBuilder.SetIsDigitalMembership(true);
            _packageBuilder.SetIsMultipleBankAccount(true);
            return _packageBuilder.Build();

        }

        #endregion
    }
}
