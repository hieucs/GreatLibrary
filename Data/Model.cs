﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatLibrary.Data
{

    public class MenuItem
    {
        public string ID { get; set; }
        public string IDParent { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public bool HasChild { get; set; }
        public string ClassID { get; set; }
        public string ClassCSS { get; set; }
    }
    public class Memu
    {
        public List<MenuItem> MenuList { get; set; }
    }
    public class Item
    {
        public int IDTruyen { get; set; }
        public string LinkImage { get; set; }
        public string TitleTruyen { get; set; }
        public string LinkTruyen { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Source { get; set; }
        public string descriptionSeo { get; set; }
        public string keywordsSeo { get; set; }
        public string Alias { get; set; }
        public string Type { get; set; }
        public string TotalchapterPageCount { get; set; }

    }
    public class Sliders
    {
        public List<Item> Slider { get; set; }
    }
    public class ListTruyenMoiCapNhat
    {
        public List<Item> TruyenMoiCapNhat { get; set; }
    }
    public class ListTruyenXemNhieuGet
    {
        public List<Item> TruyenXemNhieuGet { get; set; }
    }
    public class ListFeatured
    {
        public List<Item> Featured { get; set; }
    }
    

    public class ListTruyenHot
    {
        public List<Item> TruyenHot { get; set; }
    }

    public class ListItem
    {
        public List<Item> Item { get; set; }
        public List<Item> Similar { get; set; }
        public List<Item> Random { get; set; }
    }
    public class ListChapterParam
    {
        public string ID { get; set; }
        public string Page { get; set; }
    }

    public class ListItemInCat
    {
        public int IDTruyen { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Cat { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string LinkImageCover { get; set; }
        public string LinkTruyen { get; set; }
        public string Alias { get; set; }
    }
    public class TotalPage
    {
        public int PageCount { get; set; }
    }
    public class CatPages
    {
        public string CatName { get; set; }
    }
    public class CatetoryResult
    {
        public List<TotalPage> TotalPages { get; set; }
        public List<ListItemInCat> ListItemInCat { get; set; }
        public List<CatPages> CatPages { get; set; }
    }
    public class CategoryParam
    {
        public string Alias { get; set; }
        public string Pages { get; set; }
    }
    public class ChapterParamGet
    {
        public string ID { get; set; }
        public string ChapterID { get; set; }
    }
    public class Chapter
    {
        public int IDItem { get; set; }
        public string IDChapter { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Detail { get; set; }
        public string TotalchapterPageCount { get; set; }
        public string TitleTruyen { get; set; }
        public string Alias { get; set; }
    }

    public class ChapterList
    {
        public List<Chapter> Chapter { get; set; }
    }
    public class ListChapter
    {
        public List<Chapter> Chapters { get; set; }
    }
    public class AuthResponse
    {
        public string accessToken { get; set; }
        public string expiresIn { get; set; }
        public string reauthorize_required_in { get; set; }
        public string signedRequest { get; set; }
        public string userID { get; set; }
    }

    public class FacebookResult
    {
        public string status { get; set; }
        public AuthResponse authResponse { get; set; }
    }
    public class UserSignup
    {
        public string Email { get; set; }
        public string Pass { get; set; }
        public string FullName { get; set; }
    }
}
