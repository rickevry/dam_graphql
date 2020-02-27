using System;
using System.Collections.Generic;

namespace DAM.Core.GraphQL.SearchProxy.Schemas
{
    public class Stats
    {
        public int totalHits { get; set; }
        public int searchEngineTimeInMillis { get; set; }
        public int searchEngineRoundTripTimeInMillis { get; set; }
        public int searchProcessingTimeInMillis { get; set; }
    }

    public class Document
    {
        public string _id { get; set; }
        public string _type { get; set; }
        public string acl { get; set; }
        public DateTime added_time { get; set; }
        public string asset_type { get; set; }
        public string assetsource { get; set; }
        public string channel { get; set; }
        public string description { get; set; }
        public DateTime doc_date_time { get; set; }
        public string docid { get; set; }
        public string env { get; set; }
        public string format { get; set; }
        public List<string> language { get; set; }
        public string main_content_hash { get; set; }
        public string main_content_size { get; set; }
        public string main_content_url { get; set; }
        public string media_type { get; set; }
        public string mmid { get; set; }
        public string png_highpreview1278_size { get; set; }
        public string png_highpreview1278_url { get; set; }
        public string png_highpreview800_size { get; set; }
        public string png_highpreview800_url { get; set; }
        public string png_highpreview_size { get; set; }
        public string png_highpreview_url { get; set; }
        public string png_lowpreview_size { get; set; }
        public string png_lowpreview_url { get; set; }
        public DateTime processing_time { get; set; }
        public string publication_designation { get; set; }
        public string publicationrole { get; set; }
        public string rightsmanaged { get; set; }
        public string security_context { get; set; }
        public string security_level { get; set; }
        public List<string> taxonomy { get; set; }
        public string thumbnail_url { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string description_external { get; set; }
        public string downloads { get; set; }
        public string pdf_preview_size { get; set; }
        public string pdf_preview_standard_size { get; set; }
        public string pdf_preview_standard_url { get; set; }
        public string pdf_preview_url { get; set; }
        public string author { get; set; }
        public string display_language { get; set; }
        public List<string> industries_taxonomy { get; set; }
        public string ml_url { get; set; }
        public string mlassettype { get; set; }
        public string processingtime { get; set; }
        public string publish_status { get; set; }
        public string tab { get; set; }
        public string tcmid { get; set; }
        public string thumbnail { get; set; }
        public string thumbnailurl { get; set; }
    }

    public class PreviousPage
    {
        public string displayName { get; set; }
        public bool selected { get; set; }
        public string query { get; set; }
    }

    public class FirstPage
    {
        public string displayName { get; set; }
        public bool selected { get; set; }
        public string query { get; set; }
    }

    public class NextPage
    {
        public string displayName { get; set; }
        public bool selected { get; set; }
        public string query { get; set; }
    }

    public class Page
    {
        public string displayName { get; set; }
        public bool selected { get; set; }
        public string query { get; set; }
    }

    public class Pagination
    {
        public int offset { get; set; }
        public int hitsPerPage { get; set; }
        public FirstPage firstPage { get; set; }
        public PreviousPage previousPage { get; set; }
        public NextPage nextPage { get; set; }
        public List<Page> pages { get; set; }
    }

    public class SortOption
    {
        public string displayName { get; set; }
        public bool selected { get; set; }
        public string query { get; set; }
    }

    public class DocumentList
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public int numberOfHits { get; set; }
        public List<Document> documents { get; set; }
        public Pagination pagination { get; set; }
        public List<SortOption> sortOptions { get; set; }
    }

    public class Filter
    {
        public string displayName { get; set; }
        public bool selected { get; set; }
        public string query { get; set; }
        public int count { get; set; }
        public List<Filter> children { get; set; }
    }

    public class Facet
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string selectionType { get; set; }
        public bool multipleLevels { get; set; }
        public List<Filter> filters { get; set; }
    }

    public class Spell
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public List<object> suggestions { get; set; }
    }

    public class RootObject
    {
        public Stats stats { get; set; }
        public DocumentList documentList { get; set; }
        public List<Facet> facets { get; set; }
        public Spell spell { get; set; }
        public object quicklinks { get; set; }
        public List<object> errorMessages { get; set; }
    }
}
