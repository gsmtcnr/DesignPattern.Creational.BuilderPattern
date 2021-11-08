using DesignPattern.Creational.BuilderPattern.SubscriptionPackages;
using DesignPattern.Creational.BuilderPattern.SubscriptionPackages.Models;
using DesignPattern.Creational.BuilderPattern.SubscriptionPackages.PackageBuilders;
using System;
using System.Text;

namespace DesignPattern.Creational.BuilderPattern.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Subscription Package Builder!");

            PackageDirector packageDirector = new PackageDirector();

            //packageDirector.SetBuilder(new FreePackageBuilder());
            //PackageInformation(packageDirector.BuildFreeMonthlyPackage());

            //packageDirector.SetBuilder(new EssentialsPackageBuilder());
            //PackageInformation(packageDirector.BuildEssentialsMonthlyEssentials());

            //packageDirector.SetBuilder(new ProfessionalPackageBuilder());
            //PackageInformation(packageDirector.BuildProfessionalMonthlyEssentials());

            packageDirector.SetBuilder(new PremiumPackageBuilder());
            PackageInformation(packageDirector.BuildPremiumMonthlyEssentials());
            PackageInformation(packageDirector.BuildPremiumYearlyEssentials());
            //10k contacts
            PackageInformation(packageDirector.BuildPremiumMonthlyEssentials(contactCount: 10000));
            PackageInformation(packageDirector.BuildPremiumYearlyEssentials(contactCount: 10000));
            //15k contacts
            PackageInformation(packageDirector.BuildPremiumMonthlyEssentials(contactCount: 15000));
            PackageInformation(packageDirector.BuildPremiumYearlyEssentials(contactCount: 15000));
            Console.ReadLine();
        }

        static void PackageInformation(SubscriptionPackage subscriptionPackage)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("----");
            stringBuilder.AppendLine("Duration Type :" + subscriptionPackage.DurationType.ToString());
            stringBuilder.AppendLine("Package Type :" + subscriptionPackage.PackageType.ToString());
            stringBuilder.AppendLine("Contact Counts :" + subscriptionPackage.Contacts.ToString());
            stringBuilder.AppendLine("Unit Price :" + subscriptionPackage.UnitPrice.ToString());
            stringBuilder.AppendLine("Total Price :" + subscriptionPackage.TotalPrice.ToString());
            stringBuilder.AppendLine("PaymentTransactionFees :" + subscriptionPackage.PaymentTransactionFees.ToString());

            stringBuilder.AppendLine("----");
            Console.Write(stringBuilder.ToString());
        }
    }
}
