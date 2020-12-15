//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.TermsetDomain;
using DAM.Core.Shared.Models.PersonDomain;

namespace DAM.Core.GraphQL.Schemas.TermsetDomain
{
    public class TermModel
    {
        public string Id { get; set; }
        public string Pid { get; set; }
        public string Title { get; set; }

        public static TermModel
       FromEntity(Shared.Models.TermsetDomain.Term entity)
        {
            return new TermModel
            {
                Id = entity.Id,
                Pid = entity.Pid,
                Title = entity.Title,
            };
        }

        public static implicit operator Shared.Models.TermsetDomain.Term(TermModel entity)

        {
            return ToEntity(entity);
        }

        public static implicit operator TermModel(Shared.Models.TermsetDomain.Term entity)
        {
            return FromEntity(entity);
        }

        public static Shared.Models.TermsetDomain.Term ToEntity(TermModel entity)
        {
            return new Term
            {
                Id = entity.Id,
                Pid = entity.Pid,
                Title = entity.Title,
            };
        }

        public static List<TermModel>
        FromEntityList(List<Shared.Models.TermsetDomain.Term> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (TermModel)entity).ToList();
        }

        public static List<Shared.Models.TermsetDomain.Term>
       ToEntityList(List<TermModel> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (Shared.Models.TermsetDomain.Term)entity).ToList();
        }

    }


    [ModelName("Termset")]
    [QueryName("termset")]
    public class TermsetModel : MutableModel
    {

        private List<TermModel> _terms;
        private string _title;
        private string _eid;

        public List<TermModel> Terms
        {
            get
            {
                return _terms;
            }
            set
            {
                SetField(ref _terms, value);
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                SetField(ref _title, value);
            }
        }

        public string Eid
        {
            get
            {
                return _eid;
            }
            set
            {
                SetField(ref _eid, value);
            }
        }

        public static implicit operator TermsetModel(
            Shared.Models.TermsetDomain.Termset entity
        )

        {
            return FromEntity(entity);
        }

        public static TermsetModel
        FromEntity(Shared.Models.TermsetDomain.Termset entity)
        {
            return new TermsetModel
            {
                Id = entity.Id,
                _terms = TermModel.FromEntityList(entity.Terms),
                _title = entity.Title,
            };
        }

        public static List<TermsetModel>
        FromEntityList(List<Shared.Models.TermsetDomain.Termset> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (TermsetModel)entity).ToList();
        }

        public static implicit operator Shared.Models.TermsetDomain.Termset(
            TermsetModel entity
        )

        {
            return ToEntity(entity);
        }

        public static Shared.Models.TermsetDomain.Termset
        ToEntity(TermsetModel entity)
        {
            return new Termset
            {
                Id = entity.Id,
                Terms = TermModel.ToEntityList(entity._terms),
                Title = entity._title,
            };
        }

        public static List<Shared.Models.TermsetDomain.Termset>
        ToEntityList(List<TermsetModel> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (Shared.Models.TermsetDomain.Termset)entity).ToList();
        }
    }
}
