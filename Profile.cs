namespace Flinter
{
    /// <summary>
    /// This class represents a person profile,
    /// for instance for a dating website
    /// </summary>
    public class Profile
    {
        #region Instance fields
        private Gender _gender;
        public enum Gender { man, woman }
        private EyeColor _eyeColor;
        public enum EyeColor {blue, brown, green, other}
        private HairColor _hairColor;
        public enum HairColor {brown, blond, black, other}
        private HeightCategory _heightCategory;
        public enum HeightCategory {veryshort, Short, medium, tall, verytall, unknown}
        #endregion

        #region Constructor
        public Profile(Gender gender, EyeColor eyeColor, HairColor hairColor, HeightCategory heightCategory)
        {
            _gender = gender;
            _eyeColor = eyeColor;
            _hairColor = hairColor;
            _heightCategory = heightCategory;
        }
        #endregion

        #region Properties
        public string Description
        {
            get
            {
                return $"You got a {_gender} with {_eyeColor} eyes and {_hairColor} hair, who is {_heightCategory}";
            }
        }

        /*public string GenderDescription
        {
            get { return _gender ? "man" : "woman"; }
        }

        public string HeightDescription
        {
            get
            {
                switch (_heightCategory)
                {
                    case 0:
                        return "Very short";
                    case 1:
                        return "Short";
                    case 2:
                        return "Medium height";
                    case 3:
                        return "Tall";
                    case 4:
                        return "Very tall";
                    default:
                        return "Unknown height";
                }
            }
        }*/
        #endregion
    }
}