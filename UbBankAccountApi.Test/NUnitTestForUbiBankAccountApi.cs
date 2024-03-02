using Microsoft.AspNetCore.Http.HttpResults;
using UbBankAccountApi.Controllers;
using UbBankAccountApi.Models;

namespace UbBankAccountApi.Test
{
    public class Tests
    {
        private AccountController controller;
        [SetUp]
        public void Setup()
        {
            controller = new AccountController();
        }
        [Test]
        public void TestMethodForGetAccountDetails()
        {
            IEnumerable<AccountModel> result = controller.GetAccountDetails();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
        [Test]
        public void TestMethodForPostTeacher()
        {
            var newItem = new AccountModel
            {
                AccountNumber = 12345,
                AccountHolderNumber = "test",
                AccountType = "Savings",
                AccountBalance = 12345.54321,
                PhoneNumber = 123456789
            };
            var actionResult = controller.PostAccountDetails(newItem);
            Assert.That(actionResult, Is.Not.Null);
        }
        [Test]
        public void TestMethodForPostTeacherNull()
        {
            var newItem = new AccountModel
            {
                AccountNumber = 12345,
                AccountHolderNumber = null,
                AccountType = null,
                AccountBalance = 123.123,
                PhoneNumber = 123456789
            };
            var actionResult = controller.PostAccountDetails(newItem);
            Assert.That(actionResult, Is.Not.InstanceOf<BadRequest>());
        }
        [Test]
        public void CheckAccountNumberTypeIsNotInInt()
        {
            int item = 32;
            var newItem = new AccountModel
            {
                AccountNumber = 12345
            };
            Assert.That(newItem.AccountNumber.GetType(), Is.Not.EqualTo(item.GetType()));
        }
        [Test]
        public void CheckAccountBalanceTypeIsNotInInt()
        {
            int item = 32000;
            var newItem = new AccountModel
            {
                AccountBalance = 12345.012
            };
            Assert.That(newItem.AccountNumber.GetType(), Is.Not.EqualTo(item.GetType()));
        }
    }
}