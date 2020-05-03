using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;


namespace MSSA_CAD_Project_Lugias_Lair.Models
{
    public partial class LugiasLair_DB_ProjectContext : DbContext
    {
        public LugiasLair_DB_ProjectContext()
        {
        }

        public LugiasLair_DB_ProjectContext(DbContextOptions<LugiasLair_DB_ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ability> Ability { get; set; }
        public virtual DbSet<Characteristic> Characteristic { get; set; }
        public virtual DbSet<CustomPokemon> CustomPokemon { get; set; }
        public virtual DbSet<HeldItem> HeldItem { get; set; }
        public virtual DbSet<Nature> Nature { get; set; }
        public virtual DbSet<PictureFull> PictureFull { get; set; }
        public virtual DbSet<PictureSprite> PictureSprite { get; set; }
        public virtual DbSet<PictureTrainerSprite> PictureTrainerSprite { get; set; }
        public virtual DbSet<PokedexEntry> PokedexEntry { get; set; }
        public virtual DbSet<Pokemon> Pokemon { get; set; }
        public virtual DbSet<PokemonHasAbility> PokemonHasAbility { get; set; }
        public virtual DbSet<PokemonLearnsMove> PokemonLearnsMove { get; set; }
        public virtual DbSet<PokemonMove> PokemonMove { get; set; }
        public virtual DbSet<PokemonType> PokemonType { get; set; }
        public virtual DbSet<TeamBase> TeamBase { get; set; }
        public virtual DbSet<TeamVgc> TeamVgc { get; set; }
        public virtual DbSet<Vgcplayer> Vgcplayer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=LugiasLair_DB_Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>(entity =>
            {
                entity.Property(e => e.AbilityId).HasColumnName("abilityID");

                entity.Property(e => e.AbilityDescription)
                    .HasColumnName("abilityDescription")
                    .HasMaxLength(200);

                entity.Property(e => e.AbilityName)
                    .HasColumnName("abilityName")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Characteristic>(entity =>
            {
                entity.Property(e => e.CharacteristicId).HasColumnName("characteristicID");

                entity.Property(e => e.BenefittingStat)
                    .HasColumnName("benefittingStat")
                    .HasMaxLength(10);

                entity.Property(e => e.CharacteristicDescription)
                    .HasColumnName("characteristicDescription")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<CustomPokemon>(entity =>
            {
                entity.Property(e => e.CustomPokemonId).HasColumnName("customPokemonID");

                entity.Property(e => e.AbilityId).HasColumnName("abilityID");

                entity.Property(e => e.AttackEv).HasColumnName("attackEV");

                entity.Property(e => e.AttackIv).HasColumnName("attackIV");

                entity.Property(e => e.CharacteristicId).HasColumnName("characteristicID");

                entity.Property(e => e.DefenseEv).HasColumnName("defenseEV");

                entity.Property(e => e.DefenseIv).HasColumnName("defenseIV");

                entity.Property(e => e.HitPointEv).HasColumnName("hitPointEV");

                entity.Property(e => e.HitPointIv).HasColumnName("hitPointIV");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.MoveFourId).HasColumnName("moveFourID");

                entity.Property(e => e.MoveOneId).HasColumnName("moveOneID");

                entity.Property(e => e.MoveThreeId).HasColumnName("moveThreeID");

                entity.Property(e => e.MoveTwoId).HasColumnName("moveTwoID");

                entity.Property(e => e.NatureId).HasColumnName("natureID");

                entity.Property(e => e.OverallAttack).HasColumnName("overallAttack");

                entity.Property(e => e.OverallDefense).HasColumnName("overallDefense");

                entity.Property(e => e.OverallHitPoints).HasColumnName("overallHitPoints");

                entity.Property(e => e.OverallSpAttack).HasColumnName("overallSpAttack");

                entity.Property(e => e.OverallSpDefense).HasColumnName("overallSpDefense");

                entity.Property(e => e.OverallSpeed).HasColumnName("overallSpeed");

                entity.Property(e => e.PkmnTypeOneId).HasColumnName("pkmnTypeOneID");

                entity.Property(e => e.PkmnTypeTwoId).HasColumnName("pkmnTypeTwoID");

                entity.Property(e => e.PokedexEntryId).HasColumnName("pokedexEntryID");

                entity.Property(e => e.PokemonId).HasColumnName("pokemonID");

                entity.Property(e => e.PokemonNickname)
                    .HasColumnName("pokemonNickname")
                    .HasMaxLength(20);

                entity.Property(e => e.SpAttackEv).HasColumnName("spAttackEV");

                entity.Property(e => e.SpAttackIv).HasColumnName("spAttackIV");

                entity.Property(e => e.SpDefenseEv).HasColumnName("spDefenseEV");

                entity.Property(e => e.SpDefenseIv).HasColumnName("spDefenseIV");

                entity.Property(e => e.SpeedEv).HasColumnName("speedEV");

                entity.Property(e => e.SpeedIv).HasColumnName("speedIV");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.CustomPokemon)
                    .HasForeignKey(d => d.AbilityId)
                    .HasConstraintName("FK_Ability_CustomPokemon");

                entity.HasOne(d => d.Characteristic)
                    .WithMany(p => p.CustomPokemon)
                    .HasForeignKey(d => d.CharacteristicId)
                    .HasConstraintName("FK_Characteristic_CustomPokemon");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.CustomPokemon)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_HeldItem_CustomPokemon");

                entity.HasOne(d => d.MoveFour)
                    .WithMany(p => p.CustomPokemonMoveFour)
                    .HasForeignKey(d => d.MoveFourId)
                    .HasConstraintName("FK_MoveFour_CustomPokemon");

                entity.HasOne(d => d.MoveOne)
                    .WithMany(p => p.CustomPokemonMoveOne)
                    .HasForeignKey(d => d.MoveOneId)
                    .HasConstraintName("FK_MoveOne_CustomPokemon");

                entity.HasOne(d => d.MoveThree)
                    .WithMany(p => p.CustomPokemonMoveThree)
                    .HasForeignKey(d => d.MoveThreeId)
                    .HasConstraintName("FK_MoveThree_CustomPokemon");

                entity.HasOne(d => d.MoveTwo)
                    .WithMany(p => p.CustomPokemonMoveTwo)
                    .HasForeignKey(d => d.MoveTwoId)
                    .HasConstraintName("FK_MoveTwo_CustomPokemon");

                entity.HasOne(d => d.Nature)
                    .WithMany(p => p.CustomPokemon)
                    .HasForeignKey(d => d.NatureId)
                    .HasConstraintName("FK_Nature_CustomPokemon");

                entity.HasOne(d => d.PkmnTypeOne)
                    .WithMany(p => p.CustomPokemonPkmnTypeOne)
                    .HasForeignKey(d => d.PkmnTypeOneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeOne_CustomPokemon");

                entity.HasOne(d => d.PkmnTypeTwo)
                    .WithMany(p => p.CustomPokemonPkmnTypeTwo)
                    .HasForeignKey(d => d.PkmnTypeTwoId)
                    .HasConstraintName("FK_TypeTwo_CustomPokemon");

                entity.HasOne(d => d.PokedexEntry)
                    .WithMany(p => p.CustomPokemon)
                    .HasForeignKey(d => d.PokedexEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PokedexEntry_CustomPokemon");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.CustomPokemon)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_CustomPokemon");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CustomPokemon)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VGCPlayer_CustomPokemon");
            });

            modelBuilder.Entity<HeldItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.ItemCat)
                    .HasColumnName("itemCat")
                    .HasMaxLength(15);

                entity.Property(e => e.ItemEffect)
                    .HasColumnName("itemEffect")
                    .HasMaxLength(300);

                entity.Property(e => e.ItemName)
                    .HasColumnName("itemName")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Nature>(entity =>
            {
                entity.Property(e => e.NatureId).HasColumnName("natureID");

                entity.Property(e => e.NatureBerryDislike)
                    .HasColumnName("natureBerryDislike")
                    .HasMaxLength(10);

                entity.Property(e => e.NatureDecreases)
                    .HasColumnName("natureDecreases")
                    .HasMaxLength(20);

                entity.Property(e => e.NatureIncreses)
                    .HasColumnName("natureIncreses")
                    .HasMaxLength(20);

                entity.Property(e => e.NatureName)
                    .HasColumnName("natureName")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<PictureFull>(entity =>
            {
                entity.HasKey(e => e.PicFullId);

                entity.Property(e => e.PicFullId).HasColumnName("picFullID");

                entity.Property(e => e.PicFullData).HasColumnName("picFullData");

                entity.Property(e => e.PicFullFileName)
                    .HasColumnName("picFullFileName")
                    .HasMaxLength(100);

                entity.Property(e => e.PicFullName)
                    .IsRequired()
                    .HasColumnName("picFullName")
                    .HasMaxLength(40);

                entity.Property(e => e.PokemonId).HasColumnName("pokemonID");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PictureFull)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_Full");
            });

            modelBuilder.Entity<PictureSprite>(entity =>
            {
                entity.HasKey(e => e.PicSpriteId);

                entity.Property(e => e.PicSpriteId).HasColumnName("picSpriteID");

                entity.Property(e => e.PicSpriteData).HasColumnName("picSpriteData");

                entity.Property(e => e.PicSpriteFileName)
                    .HasColumnName("picSpriteFileName")
                    .HasMaxLength(100);

                entity.Property(e => e.PicSpriteName)
                    .IsRequired()
                    .HasColumnName("picSpriteName")
                    .HasMaxLength(40);

                entity.Property(e => e.PokemonId).HasColumnName("pokemonID");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PictureSprite)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_Sprite");
            });

            modelBuilder.Entity<PictureTrainerSprite>(entity =>
            {
                entity.HasKey(e => e.PicTrainerSpriteId);

                entity.Property(e => e.PicTrainerSpriteId).HasColumnName("picTrainerSpriteID");

                entity.Property(e => e.PicTrainerSpriteData).HasColumnName("picTrainerSpriteData");

                entity.Property(e => e.PicTrainerSpriteFileName)
                    .HasColumnName("picTrainerSpriteFileName")
                    .HasMaxLength(100);

                entity.Property(e => e.PicTrainerSpriteName)
                    .IsRequired()
                    .HasColumnName("picTrainerSpriteName")
                    .HasMaxLength(40);

                entity.Property(e => e.PokemonId).HasColumnName("pokemonID");
            });

            modelBuilder.Entity<PokedexEntry>(entity =>
            {
                entity.Property(e => e.PokedexEntryId).HasColumnName("pokedexEntryID");

                entity.Property(e => e.PokedexEntry1)
                    .HasColumnName("pokedexEntry")
                    .HasMaxLength(256);

                entity.Property(e => e.PokemonId).HasColumnName("pokemonID");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokedexEntry)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID");
            });

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.Property(e => e.PokemonId).HasColumnName("pokemonID");

                entity.Property(e => e.PokemonAttack).HasColumnName("pokemonAttack");

                entity.Property(e => e.PokemonDefense).HasColumnName("pokemonDefense");

                entity.Property(e => e.PokemonHitPoints).HasColumnName("pokemonHitPoints");

                entity.Property(e => e.PokemonName)
                    .HasColumnName("pokemonName")
                    .HasMaxLength(50);

                entity.Property(e => e.PokemonNumber).HasColumnName("pokemonNumber");

                entity.Property(e => e.PokemonSpecialAttack).HasColumnName("pokemonSpecialAttack");

                entity.Property(e => e.PokemonSpecialDefense).HasColumnName("pokemonSpecialDefense");

                entity.Property(e => e.PokemonSpeed).HasColumnName("pokemonSpeed");

                entity.Property(e => e.PokemonStatTotal).HasColumnName("pokemonStatTotal");

                entity.Property(e => e.PokemonTypeOne).HasColumnName("pokemonTypeOne");

                entity.Property(e => e.PokemonTypeTwo).HasColumnName("pokemonTypeTwo");

                entity.HasOne(d => d.PokemonTypeOneNavigation)
                    .WithMany(p => p.PokemonPokemonTypeOneNavigation)
                    .HasForeignKey(d => d.PokemonTypeOne)
                    .HasConstraintName("FK_Pokemon_Type_One");

                entity.HasOne(d => d.PokemonTypeTwoNavigation)
                    .WithMany(p => p.PokemonPokemonTypeTwoNavigation)
                    .HasForeignKey(d => d.PokemonTypeTwo)
                    .HasConstraintName("FK_Pokemon_Type_Two");
            });

            modelBuilder.Entity<PokemonHasAbility>(entity =>
            {
                entity.HasKey(e => e.PkmnAbilityId);

                entity.Property(e => e.PkmnAbilityId).HasColumnName("pkmnAbilityID");

                entity.Property(e => e.AbilityId).HasColumnName("abilityID");

                entity.Property(e => e.HiddenAbility).HasColumnName("hiddenAbility");

                entity.Property(e => e.PokemonId).HasColumnName("pokemonID");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.PokemonHasAbility)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ability_Pokemon");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonHasAbility)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_Ability");
            });

            modelBuilder.Entity<PokemonLearnsMove>(entity =>
            {
                entity.HasKey(e => e.PkmnMoveId);

                entity.Property(e => e.PkmnMoveId).HasColumnName("pkmnMoveID");

                entity.Property(e => e.MoveId).HasColumnName("moveID");

                entity.Property(e => e.PokemonId).HasColumnName("pokemonID");

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.PokemonLearnsMove)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Move_Pokemon");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonLearnsMove)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_Move");
            });

            modelBuilder.Entity<PokemonMove>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.Property(e => e.MoveId).HasColumnName("moveID");

                entity.Property(e => e.MoveAccuracy).HasColumnName("moveAccuracy");

                entity.Property(e => e.MoveCategory)
                    .HasColumnName("moveCategory")
                    .HasMaxLength(20);

                entity.Property(e => e.MoveEffect)
                    .HasColumnName("moveEffect")
                    .HasMaxLength(300);

                entity.Property(e => e.MoveEffectProb).HasColumnName("moveEffectProb");

                entity.Property(e => e.MoveName)
                    .HasColumnName("moveName")
                    .HasMaxLength(30);

                entity.Property(e => e.MovePoints).HasColumnName("movePoints");

                entity.Property(e => e.MovePower).HasColumnName("movePower");

                entity.Property(e => e.MoveType).HasColumnName("moveType");

                entity.HasOne(d => d.MoveTypeNavigation)
                    .WithMany(p => p.PokemonMove)
                    .HasForeignKey(d => d.MoveType)
                    .HasConstraintName("FK_Move_Type");
            });

            modelBuilder.Entity<PokemonType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.TypeName)
                    .HasColumnName("typeName")
                    .HasMaxLength(15);

                entity.Property(e => e.TypeNumber).HasColumnName("typeNumber");
            });

            modelBuilder.Entity<TeamBase>(entity =>
            {
                entity.Property(e => e.TeamBaseId).HasColumnName("teamBaseID");

                entity.Property(e => e.PokemonFiveId).HasColumnName("pokemonFiveID");

                entity.Property(e => e.PokemonFourId).HasColumnName("pokemonFourID");

                entity.Property(e => e.PokemonOneId).HasColumnName("pokemonOneID");

                entity.Property(e => e.PokemonSixId).HasColumnName("pokemonSixID");

                entity.Property(e => e.PokemonThreeId).HasColumnName("pokemonThreeID");

                entity.Property(e => e.PokemonTwoId).HasColumnName("pokemonTwoID");

                entity.Property(e => e.TeamBaseName)
                    .HasColumnName("teamBaseName")
                    .HasMaxLength(30);

                entity.Property(e => e.TeamPublic).HasColumnName("teamPublic");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.PokemonFive)
                    .WithMany(p => p.TeamBasePokemonFive)
                    .HasForeignKey(d => d.PokemonFiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_Five");

                entity.HasOne(d => d.PokemonFour)
                    .WithMany(p => p.TeamBasePokemonFour)
                    .HasForeignKey(d => d.PokemonFourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_Four");

                entity.HasOne(d => d.PokemonOne)
                    .WithMany(p => p.TeamBasePokemonOne)
                    .HasForeignKey(d => d.PokemonOneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_One");

                entity.HasOne(d => d.PokemonSix)
                    .WithMany(p => p.TeamBasePokemonSix)
                    .HasForeignKey(d => d.PokemonSixId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_Six");

                entity.HasOne(d => d.PokemonThree)
                    .WithMany(p => p.TeamBasePokemonThree)
                    .HasForeignKey(d => d.PokemonThreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_Three");

                entity.HasOne(d => d.PokemonTwo)
                    .WithMany(p => p.TeamBasePokemonTwo)
                    .HasForeignKey(d => d.PokemonTwoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_Two");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TeamBase)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_ID");
            });

            modelBuilder.Entity<TeamVgc>(entity =>
            {
                entity.ToTable("TeamVGC");

                entity.Property(e => e.TeamVgcid).HasColumnName("teamVGCID");

                entity.Property(e => e.PkmnVgcfourId).HasColumnName("pkmnVGCFourID");

                entity.Property(e => e.PkmnVgconeId).HasColumnName("pkmnVGCOneID");

                entity.Property(e => e.PkmnVgcthreeId).HasColumnName("pkmnVGCThreeID");

                entity.Property(e => e.PkmnVgctwoId).HasColumnName("pkmnVGCTwoID");

                entity.Property(e => e.TeamBaseId).HasColumnName("teamBaseID");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.PkmnVgcfour)
                    .WithMany(p => p.TeamVgcPkmnVgcfour)
                    .HasForeignKey(d => d.PkmnVgcfourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_Four_VGC");

                entity.HasOne(d => d.PkmnVgcone)
                    .WithMany(p => p.TeamVgcPkmnVgcone)
                    .HasForeignKey(d => d.PkmnVgconeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_One_VGC");

                entity.HasOne(d => d.PkmnVgcthree)
                    .WithMany(p => p.TeamVgcPkmnVgcthree)
                    .HasForeignKey(d => d.PkmnVgcthreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_Three_VGC");

                entity.HasOne(d => d.PkmnVgctwo)
                    .WithMany(p => p.TeamVgcPkmnVgctwo)
                    .HasForeignKey(d => d.PkmnVgctwoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pokemon_ID_Two_VGC");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TeamVgc)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_ID_VGC");
            });

            modelBuilder.Entity<Vgcplayer>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("VGCPlayer");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserEmail)
                    .HasColumnName("userEmail")
                    .HasMaxLength(75);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPassword)
                    .HasColumnName("userPassword")
                    .HasMaxLength(256);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
