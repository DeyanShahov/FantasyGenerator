namespace FantasyGenerator.Infrastructure.Data
{
    public class DataConstants
    {
        public class User
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;
            public const int GuidMaxLength = 68;
        }

        public class Race
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 20;
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 200;
        }

        public class Feat
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;
            public const int PrerequisiteMinLength = 5;
            public const int PrerequisiteMaxLength = 50;
        }

        public class Skill
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;
            public const int PrerequisiteMinLength = 5;
            public const int PrerequisiteMaxLength = 50;
        }

        public class Npc
        {
            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 20;
            public const int LastNameMinLength = 3;
            public const int LastNameMaxLength = 20;
        }

        public class NpcName
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 20;
            public const int NickNameSuffixMinLength = 3;
            public const int NickNameSuffixMaxLength = 20;
            public const int NickNamePrefixMinLength = 3;
            public const int NickNamePrefixMaxLength = 20;
        }

        public class NpcCategoryName
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 100;
        }


        public class ProfessionCategory
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 100;
        }

        public class Profession
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 200;
        }
    }
}
