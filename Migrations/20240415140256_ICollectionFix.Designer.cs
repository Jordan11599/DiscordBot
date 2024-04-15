﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiscordBot.Migrations
{
    [DbContext(typeof(DBConnection))]
    [Migration("20240415140256_ICollectionFix")]
    partial class ICollectionFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("DiscordBot.Models.Additions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharactersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Percent")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CharactersId");

                    b.ToTable("Additions");
                });

            modelBuilder.Entity("DiscordBot.Models.Attributes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharactersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Light_ConeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Percent")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CharactersId");

                    b.HasIndex("Light_ConeId");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("DiscordBot.Models.Avatar", b =>
                {
                    b.Property<int>("AvatarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AvatarId");

                    b.ToTable("Avatar");
                });

            modelBuilder.Entity("DiscordBot.Models.Characters", b =>
                {
                    b.Property<int>("CharactersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ElementId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Light_ConeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PathId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Preview")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Promotion")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rank_Icons")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rarity")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharactersId");

                    b.HasIndex("ElementId");

                    b.HasIndex("Light_ConeId");

                    b.HasIndex("PathId");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DiscordBot.Models.Element", b =>
                {
                    b.Property<int>("ElementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ElementId");

                    b.ToTable("Element");
                });

            modelBuilder.Entity("DiscordBot.Models.Light_Cone", b =>
                {
                    b.Property<int>("Light_ConeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PathId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Portrait")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Preview")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Promotion")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rarity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Light_ConeId");

                    b.HasIndex("PathId");

                    b.ToTable("Light_Cone");
                });

            modelBuilder.Entity("DiscordBot.Models.Main_Affix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Percent")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Main_Affix");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Main_Affix");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DiscordBot.Models.Memory_Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Chaos_Id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Chaos_Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Memory_Data");
                });

            modelBuilder.Entity("DiscordBot.Models.Path", b =>
                {
                    b.Property<int>("PathId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PathId");

                    b.ToTable("Path");
                });

            modelBuilder.Entity("DiscordBot.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AvatarId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Friend_Count")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Is_Display")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Space_InfoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("World_Level")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.HasIndex("Space_InfoId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("DiscordBot.Models.Properties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharactersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Light_ConeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Percent")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Relic_SetsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CharactersId");

                    b.HasIndex("Light_ConeId");

                    b.HasIndex("Relic_SetsId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("DiscordBot.Models.Relic_Sets", b =>
                {
                    b.Property<int>("Relic_SetsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharactersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Num")
                        .HasColumnType("INTEGER");

                    b.HasKey("Relic_SetsId");

                    b.HasIndex("CharactersId");

                    b.ToTable("Relic_Sets");
                });

            modelBuilder.Entity("DiscordBot.Models.Relics", b =>
                {
                    b.Property<int>("RelicsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharactersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Main_AffixId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rarity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Set_Id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Set_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RelicsId");

                    b.HasIndex("CharactersId");

                    b.HasIndex("Main_AffixId");

                    b.ToTable("Relics");
                });

            modelBuilder.Entity("DiscordBot.Models.Skill_Trees", b =>
                {
                    b.Property<int>("Skill_TreesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Anchor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CharactersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Max_Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Parent")
                        .HasColumnType("TEXT");

                    b.HasKey("Skill_TreesId");

                    b.HasIndex("CharactersId");

                    b.ToTable("Skill_Trees");
                });

            modelBuilder.Entity("DiscordBot.Models.Skills", b =>
                {
                    b.Property<int>("SkillsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharactersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Effect")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Effect_Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ElementId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Max_Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Simple_Desc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type_Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SkillsId");

                    b.HasIndex("CharactersId");

                    b.HasIndex("ElementId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("DiscordBot.Models.Space_Info", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Achievement_Count")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Avatar_Count")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Light_Cone_Count")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Memory_DataId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Universe_Level")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Memory_DataId");

                    b.ToTable("Space_Info");
                });

            modelBuilder.Entity("DiscordBot.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discord_Id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DiscordBot.Models.Sub_Affix", b =>
                {
                    b.HasBaseType("DiscordBot.Models.Main_Affix");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RelicsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Step")
                        .HasColumnType("INTEGER");

                    b.HasIndex("RelicsId");

                    b.HasDiscriminator().HasValue("Sub_Affix");
                });

            modelBuilder.Entity("DiscordBot.Models.Additions", b =>
                {
                    b.HasOne("DiscordBot.Models.Characters", null)
                        .WithMany("Additions")
                        .HasForeignKey("CharactersId");
                });

            modelBuilder.Entity("DiscordBot.Models.Attributes", b =>
                {
                    b.HasOne("DiscordBot.Models.Characters", null)
                        .WithMany("Attributes")
                        .HasForeignKey("CharactersId");

                    b.HasOne("DiscordBot.Models.Light_Cone", null)
                        .WithMany("Attributes")
                        .HasForeignKey("Light_ConeId");
                });

            modelBuilder.Entity("DiscordBot.Models.Characters", b =>
                {
                    b.HasOne("DiscordBot.Models.Element", "Element")
                        .WithMany()
                        .HasForeignKey("ElementId");

                    b.HasOne("DiscordBot.Models.Light_Cone", "Light_Cone")
                        .WithMany()
                        .HasForeignKey("Light_ConeId");

                    b.HasOne("DiscordBot.Models.Path", "Path")
                        .WithMany()
                        .HasForeignKey("PathId");

                    b.HasOne("DiscordBot.Models.User", null)
                        .WithMany("Characters")
                        .HasForeignKey("UserId");

                    b.Navigation("Element");

                    b.Navigation("Light_Cone");

                    b.Navigation("Path");
                });

            modelBuilder.Entity("DiscordBot.Models.Light_Cone", b =>
                {
                    b.HasOne("DiscordBot.Models.Path", "Path")
                        .WithMany()
                        .HasForeignKey("PathId");

                    b.Navigation("Path");
                });

            modelBuilder.Entity("DiscordBot.Models.Player", b =>
                {
                    b.HasOne("DiscordBot.Models.Avatar", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.HasOne("DiscordBot.Models.Space_Info", "Space_Info")
                        .WithMany()
                        .HasForeignKey("Space_InfoId");

                    b.Navigation("Avatar");

                    b.Navigation("Space_Info");
                });

            modelBuilder.Entity("DiscordBot.Models.Properties", b =>
                {
                    b.HasOne("DiscordBot.Models.Characters", null)
                        .WithMany("Properties")
                        .HasForeignKey("CharactersId");

                    b.HasOne("DiscordBot.Models.Light_Cone", null)
                        .WithMany("Properties")
                        .HasForeignKey("Light_ConeId");

                    b.HasOne("DiscordBot.Models.Relic_Sets", null)
                        .WithMany("Properties")
                        .HasForeignKey("Relic_SetsId");
                });

            modelBuilder.Entity("DiscordBot.Models.Relic_Sets", b =>
                {
                    b.HasOne("DiscordBot.Models.Characters", null)
                        .WithMany("Relic_Sets")
                        .HasForeignKey("CharactersId");
                });

            modelBuilder.Entity("DiscordBot.Models.Relics", b =>
                {
                    b.HasOne("DiscordBot.Models.Characters", null)
                        .WithMany("Relics")
                        .HasForeignKey("CharactersId");

                    b.HasOne("DiscordBot.Models.Main_Affix", "Main_Affix")
                        .WithMany()
                        .HasForeignKey("Main_AffixId");

                    b.Navigation("Main_Affix");
                });

            modelBuilder.Entity("DiscordBot.Models.Skill_Trees", b =>
                {
                    b.HasOne("DiscordBot.Models.Characters", null)
                        .WithMany("Skill_Trees")
                        .HasForeignKey("CharactersId");
                });

            modelBuilder.Entity("DiscordBot.Models.Skills", b =>
                {
                    b.HasOne("DiscordBot.Models.Characters", null)
                        .WithMany("Skills")
                        .HasForeignKey("CharactersId");

                    b.HasOne("DiscordBot.Models.Element", "Element")
                        .WithMany()
                        .HasForeignKey("ElementId");

                    b.Navigation("Element");
                });

            modelBuilder.Entity("DiscordBot.Models.Space_Info", b =>
                {
                    b.HasOne("DiscordBot.Models.Memory_Data", "Memory_Data")
                        .WithMany()
                        .HasForeignKey("Memory_DataId");

                    b.Navigation("Memory_Data");
                });

            modelBuilder.Entity("DiscordBot.Models.User", b =>
                {
                    b.HasOne("DiscordBot.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("DiscordBot.Models.Sub_Affix", b =>
                {
                    b.HasOne("DiscordBot.Models.Relics", null)
                        .WithMany("Sub_Affix")
                        .HasForeignKey("RelicsId");
                });

            modelBuilder.Entity("DiscordBot.Models.Characters", b =>
                {
                    b.Navigation("Additions");

                    b.Navigation("Attributes");

                    b.Navigation("Properties");

                    b.Navigation("Relic_Sets");

                    b.Navigation("Relics");

                    b.Navigation("Skill_Trees");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("DiscordBot.Models.Light_Cone", b =>
                {
                    b.Navigation("Attributes");

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("DiscordBot.Models.Relic_Sets", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("DiscordBot.Models.Relics", b =>
                {
                    b.Navigation("Sub_Affix");
                });

            modelBuilder.Entity("DiscordBot.Models.User", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
