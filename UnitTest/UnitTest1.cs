using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {

                var startPoint = new GeoPoint(45, 90);
                var endPoint1 = new GeoPoint(45, 90);
                var endPoint2 = new GeoPoint(0, 0);


                var greatCircleDistanceZero = startPoint.GreatCircleDistanceInKm(endPoint1);
                var greatCircleDistanceBig = startPoint.GreatCircleDistanceInKm(endPoint2);


                Assert.AreEqual(0, greatCircleDistanceZero);
                Assert.AreEqual(10007.543398010288, greatCircleDistanceBig);
            }
        }
        
    }

}