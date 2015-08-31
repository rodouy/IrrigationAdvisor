using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GridMvc.DataAnnotations;

namespace IrrigationAdvisor.Models.GridHome
{

    public class GridPivotHome
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// Fields of Class:
        ///      
        ///
        /// </summary>
        private string pivotName;
        private string phenology;
        private string cultivation;
        private List<GridPivotDetailHome> listGridPivotDetailHome;

        #endregion

        #region Properties

        public virtual string PivotName
        {
            get { return pivotName; }
            set
            {
                pivotName = value;
            }
        }

        public string Phenology
        {
            get { return phenology; }
            set
            {
                phenology = value;
            }
        }

        public string Cultivation
        {
            get { return cultivation; }
            set
            {
                cultivation = value;
            }
        }

        public virtual List<GridPivotDetailHome> ListGridPivotDetailHome
        {
            get { return listGridPivotDetailHome; }
            set
            {
                listGridPivotDetailHome = value;
            }
        }

        #endregion


        public GridPivotHome(string pPivotName, string pPhenology, string pCultivation, List<GridPivotDetailHome> plistGridPivotDetailHome)
        {
            this.PivotName = pPivotName;
            this.Phenology = pPhenology;
            this.Cultivation = pCultivation;
            this.ListGridPivotDetailHome = plistGridPivotDetailHome;
        }


    }
}