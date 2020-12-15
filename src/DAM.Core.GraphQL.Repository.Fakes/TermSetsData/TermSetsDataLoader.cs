using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using DAM.Core.Shared.Models.TermsetDomain;

namespace DAM.Core.GraphQL.Repository.Fakes.TermSetsData
{
    public class TermSetsDataLoader
    {

        static Dictionary<string, List<Termset>> dict = new Dictionary<string, List<Termset>>();

        static private string getFileName(string termName)
        {
            switch (termName)
            {
                case "AssetTypes": return "Asset types.json";
                case "Catgories": return "Catgories.json";
                case "Industries": return "Industries.json";
                case "Products": return "Products.json";
                case "PublishingUnits": return "Publishing unit.json";
                case "ServicesAndSolutions": return "Services and solutions.json";
            }
            return "";
        }


        static public List<Termset> Load(string termName)
        {

            if (dict.ContainsKey(termName))
            {
                return dict[termName];
            }

            string fileName = getFileName(termName);

            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string location = Path.Combine(executableLocation, "TermSetsData", fileName);
            string json = System.IO.File.ReadAllText(location);
            JArray jArray = JArray.Parse(json);

            Termset termset = new Termset()
            {
                Eid = termName,
                Id = Guid.NewGuid(),
                Title = termName,
                Terms = new List<Term>()

            };

            foreach (JObject item in jArray)
            {
                string EntityType = item.GetValue("EntityType").ToString();
                string TermId = item.GetValue("TermId").ToString();
                string TermName = item.GetValue("TermName").ToString();
                string ParentId = item.GetValue("ParentId").ToString();
                string Path = item.GetValue("Path").ToString();

                Term term = new Term()
                { 
                    Id = TermId,
                    Pid = ParentId, 
                    Title = TermName
                };

                termset.Terms.Add(term);

            }

            var result = new List<Termset>();
            result.Add(termset);

            dict.Add(termName, result);

            return result;
        }
    }
}
