namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c0a33f07-8e7a-4661-90ae-c9d8cb532234', N'admin@gmail.com', 0, N'AIhEUzVBm13OwpOSNiulb5aCjM7KAmGsBrHzWQgRFXx3AIBgVQJ1crsIupMPuLvCUw==', N'27768fee-e3b9-4b77-98d9-7fd2c165d136', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ff6b20f7-8d2e-4321-8f17-202d9db4e9b5', N'ahmed.vuw@gmail.com', 0, N'AKV5guVForhkbrJw8ZlUPPr4DDy82z5pJazLB8Motm5qFiQUcDgFf/Cnf7lzyi5NDQ==', N'ed269a20-195a-4988-bb6d-5bbb6d7c29b5', NULL, 0, 0, NULL, 1, 0, N'ahmed.vuw@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6e5b8d65-cdf9-4454-837c-23c5b63082ba', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c0a33f07-8e7a-4661-90ae-c9d8cb532234', N'6e5b8d65-cdf9-4454-837c-23c5b63082ba')

");
        }

        public override void Down()
        {
        }
    }
}
