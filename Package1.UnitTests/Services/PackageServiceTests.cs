using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Package1.Core.Package.Models;
using Package1.Core.Package.Proxy.Interfaces;
using Package1.Core.Package.Services;
using Package1.Core.Package.Services.Interfaces;

namespace Package1.UnitTests.Services
{
    [TestFixture]
    public class PackageServiceTests
    {

        private IPackageService _sut;

        [SetUp]
        public void Setup()
        {
            var mockedBundleProxy = new Mock<IBundleProxy>();


            var rootObject = new Package
            {
                BundleList = new Bundle[]
                {
                    new Bundle {BundleId=5,ProviderId = 2},
                    new Bundle {BundleId=4,ProviderId = 3}
                }
            };

            mockedBundleProxy.Setup(e => e.GetBundleDetails())
                .Returns(Task.FromResult(rootObject));

            _sut = new PackageService(mockedBundleProxy.Object);
        }

        [Test]
        public async Task Given_InvalidBundleId_ReturnNullObject()
        {
            //Arrange
            var bundleId = 0;

            // Act
            var bundle = await _sut.ReadBundleData(bundleId);
            
            // Assert
            Assert.IsNull(bundle);

        }

        [Test]
        public async Task Given_ValidBundleId_ReturnNullObject()
        {
            //Arrange
            var bundleId = 5;

            // Act
            var bundle = await _sut.ReadBundleData(bundleId);

            // Assert
            Assert.IsNotNull(bundle);
            Assert.IsTrue(bundle.BundleId==bundleId);

        }

    }

}