namespace FantasyGenerator.Infrastructure.Data
{
    public class DataConstants
    {
        public const int GuidMaxLength = 68;
        public const int DescriptionMaxLength = 500;

        public class User
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;
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

        public class DefaultUserRole
        {
            public const string RoleId = "150fb092-25dd-42fa-8e64-d461cfbc95c1";
            public const string ConcurrencyStamp = "5f6a48ef-0337-4981-ba78-7f6a9afb08b7";
        }

        public class DefaultUser
        {
            public const string UserId = "0bb5d373-977e-46ae-9763-efe5a6ed1ecb";
            public const string ConcurrencyStamp = "fd3af8c1-8f16-478a-9315-b4fc59dd563f";
        }
    }
}
