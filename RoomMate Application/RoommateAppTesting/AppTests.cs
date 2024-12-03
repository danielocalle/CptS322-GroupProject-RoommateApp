using RoommateAppLibrary;

namespace RoommateAppTesting
{
    public class AppTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPreferenceConstruction_StringParameter()
        {
            Preferences preferences = new Preferences("000111");

            Assert.That(preferences.isQuiet, Is.False);
            Assert.That(preferences.hasPets, Is.False);
            Assert.That(preferences.earlyRiser, Is.False);
            Assert.That(preferences.stayUpLate, Is.True);
            Assert.That(preferences.spentTimeRoommate, Is.True);
            Assert.That(preferences.CommonAreaTidy, Is.True);
        }

        [Test]
        public void TestPreferencesConverter_ToString()
        {
            Preferences preferences = new Preferences("000111");

            Assert.That(preferences.ConvertPreferencesToString(), Is.EqualTo("000111"));
        }

        [Test]
        public void TestMatchScoreCalculation_NoneMatching()
        {
            Preferences preferences1 = new Preferences("111000");
            Preferences preferences2 = new Preferences("000111");

            int matchScore = RoommateApp.CalculateScore(preferences1, preferences2);

            Assert.That(matchScore, Is.EqualTo(0));
        }

        [Test]
        public void TestMatchScoreCalculation_SomeMatching()
        {
            Preferences preferences1 = new Preferences("101000");
            Preferences preferences2 = new Preferences("111010");

            int matchScore = RoommateApp.CalculateScore(preferences1, preferences2);

            Assert.That(matchScore, Is.EqualTo(4));
        }

        [Test]
        public void TestMatchScoreCalculation_AllMatching()
        {
            Preferences preferences1 = new Preferences("101010");
            Preferences preferences2 = new Preferences("101010");

            int matchScore = RoommateApp.CalculateScore(preferences1, preferences2);

            Assert.That(matchScore, Is.EqualTo(6));
        }
    }
}