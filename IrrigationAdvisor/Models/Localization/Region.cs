using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Agriculture;



namespace IrrigationAdvisor.Models.Localization
{
    /// <summary>
    /// Create: 2014-10-22
    /// Author: monicarle
    /// Description: 
    ///     Describes a region
    ///     
    /// References:
    ///     Location
    ///     
    /// Dependencies:
    ///     Location
    ///     Specie
    ///     CropCoefficient
    ///     Crop
    ///     EffectiveRainList
    ///     CropIrrigationWeather
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - regionId int
    ///     - name String
    ///     - location Location
    ///     - specieList: List<Specie>
    ///     - effectiveRainList LiEffectiveRainListRain>
    /// 
    /// Methods:
    ///     - Region()      -- constructor
    ///     - Region(name)  -- consturctor with parameters
    ///     - SetLocation(Location): bool
    /// 
    /// </summary>
    //[Serializable()]
    public class Region
    {
        #region Consts
        #endregion

        #region Fields

        /// <summary>
        /// The fields are:
        ///     - regionId: identifier
        ///     - name: the name of the region
        ///     - location: the location of the region
        ///     - specieList: list of the species of the region
        ///     - effectiveRainList: effective lRainItem (by month) for the region
        ///     
        /// </summary>
        private long regionId;
        private String name;
        private long positionId;
        private List<Specie> specieList;
        private List<SpecieCycle> specieCycleList;
        private List<EffectiveRain> effectiveRainList;

        #endregion

        #region Properties

        
        public long RegionId
        {
            get { return regionId; }
            set { regionId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        public virtual Position Position
        {
            get ; 
            set ; 
        }

        public List<Specie> SpecieList
        {
            get { return specieList; }
            set { specieList = value; }
        }

        public List<SpecieCycle> SpecieCycleList
        {
            get { return specieCycleList; }
            set { specieCycleList = value; }
        }
        
        public List<EffectiveRain> EffectiveRainList
        {
            get { return effectiveRainList; }
            set { effectiveRainList = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Region()
        {
            this.regionId = 0;
            this.Name = "";
            this.PositionId = 0;
            this.Position = new Position();
            this.SpecieList = new List<Specie>();
            this.SpecieCycleList = new List<SpecieCycle>();
            this.EffectiveRainList = new List<EffectiveRain>();
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pRegionId"></param>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        public Region(long pRegionId, String pName, long pPositionId)
        {
            this.regionId = pRegionId;
            this.Name = pName;
            this.PositionId = pPositionId;
            this.SpecieList = new List<Specie>();
            this.SpecieCycleList = new List<SpecieCycle>();
            this.EffectiveRainList = new List<EffectiveRain>();
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pRegionId"></param>
        /// <param name="pName"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pSpecieList"></param>
        /// <param name="pSpecieCycleList"></param>
        /// <param name="pEffectiveRainList"></param>
        public Region(long pRegionId, String pName, long pPositionId,
                    List<Specie> pSpecieList, 
                    List<SpecieCycle> pSpecieCycleList,
                    List<EffectiveRain> pEffectiveRainList)
        {
            this.regionId = pRegionId;
            this.Name = pName;
            this.PositionId = pPositionId;
            this.SpecieList = pSpecieList;
            this.SpecieCycleList = pSpecieCycleList;
            this.EffectiveRainList = pEffectiveRainList;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        #region EffectiveRainList

        /// <summary>
        /// If EffectiveRainList exists in List, return the Effective Rain, else null
        /// </summary>
        /// <param name="pEffectiveRain"></param>
        /// <returns></returns>
        public EffectiveRain ExistEffectiveRain(EffectiveRain pEffectiveRain)
        {
            EffectiveRain lReturn = null;
            foreach (EffectiveRain item in EffectiveRainList)
            {
                if(item.Equals(pEffectiveRain))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Effective Rain to List if not exists,
        /// if exists return null
        /// </summary>
        /// <param name="pMonth"></param>
        /// <param name="pMinRain"></param>
        /// <param name="pMaxRain"></param>
        /// <param name="pPercentage"></param>
        /// <returns></returns>
        public EffectiveRain AddEffectiveRain(int pMonth, Double pMinRain, 
                                            Double pMaxRain, Double pPercentage)
        {
            EffectiveRain lReturn = null;
            EffectiveRain lEffectiveRain = new EffectiveRain(pMonth, pMinRain, pMaxRain, pPercentage);
            if (ExistEffectiveRain(lEffectiveRain) == null)
            {
                this.EffectiveRainList.Add(lEffectiveRain);
                lReturn = lEffectiveRain;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the effective lRainItem if exists in List, else return null
        /// </summary>
        /// <param name="pMonth"></param>
        /// <param name="pMinRain"></param>
        /// <param name="pMaxRain"></param>
        /// <param name="pPercentage"></param>
        /// <returns></returns>
        public EffectiveRain UpdateEffectiveRain(int pMonth, Double pMinRain, 
                                            Double pMaxRain, Double pPercentage)
        {
            EffectiveRain lReturn = null;
            EffectiveRain lEffectiveRain = new EffectiveRain(pMonth, pMinRain, pMaxRain, pPercentage);
            lReturn = ExistEffectiveRain(lEffectiveRain);
            if (lReturn != null)
            {
                lReturn.Month = pMonth;
                lReturn.MinRain = pMinRain;
                lReturn.MaxRain = pMaxRain;
                lReturn.Percentage = pPercentage;
            }
            return lReturn;
        }


        #endregion

        #region SpecieCycleList

        /// <summary>
        /// Return the SpecieCycle that has the same parameters, else return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public SpecieCycle FindSpecieCycle(String pName)
        {
            SpecieCycle lReturn = null;
            if (!String.IsNullOrEmpty(pName))
            {
                foreach (SpecieCycle item in this.SpecieCycleList)
                {
                    if (item.Name.Equals(pName))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If SpecieCycle exists in List return the SpecieCycle, else null
        /// </summary>
        /// <param name="pSpecieCycle"></param>
        /// <returns></returns>
        public SpecieCycle ExistSpecieCycle(SpecieCycle pSpecieCycle)
        {
            SpecieCycle lReturn = null;
            if (pSpecieCycle != null)
            {
                foreach (SpecieCycle item in this.SpecieCycleList)
                {
                    if (item.Equals(pSpecieCycle))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a new SpecieCycle and return it, if exists return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public SpecieCycle AddSpecieCycle(String pName)
        {
            SpecieCycle lReturn = null;
            SpecieCycle lSpecieCycle = new SpecieCycle(0, pName);
            if (ExistSpecieCycle(lSpecieCycle) == null)
            {
                this.SpecieCycleList.Add(lSpecieCycle);
                lReturn = lSpecieCycle;
            }
            return lReturn;
        }

        #endregion

        #region Specie

        /// <summary>
        /// Return list of Species that contains the parameter in his name, else return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public List<Specie> ContainInSpecie(String pName)
        {
            List<Specie> lReturn = null;
            if (!String.IsNullOrEmpty(pName))
            {
                lReturn = new List<Specie>();
                foreach (Specie item in this.SpecieList)
                {
                    if (item.Name.Contains(pName))
                    {
                        lReturn.Add(item);                        
                    }
                }
                if(lReturn.Count == 0)
                {
                    lReturn = null;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return list of Species with same Specie Cycle, else return null.
        /// </summary>
        /// <param name="pSpecieCycle"></param>
        /// <returns></returns>
        public List<Specie> FindSpecieList(SpecieCycle pSpecieCycle)
        {
            List<Specie> lReturn = null;
            if (pSpecieCycle != null)
            {
                lReturn = new List<Specie>();
                foreach (Specie item in this.SpecieList)
                {
                    if (item.SpecieCycle.Equals(pSpecieCycle))
                    {
                        lReturn.Add(item);
                    }
                }
                if (lReturn.Count == 0)
                {
                    lReturn = null;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Specie that has the same parameters, else return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Specie FindSpecie(String pName)
        {
            Specie lReturn = null;
            if (!String.IsNullOrEmpty(pName))
            {
                foreach (Specie item in this.SpecieList)
                {
                    if (item.Name.Equals(pName))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If Specie exists in List return the Specie, else null
        /// </summary>
        /// <param name="pSpecieCycle"></param>
        /// <returns></returns>
        public Specie ExistSpecie(Specie pSpecie)
        {
            Specie lReturn = null;
            if(pSpecie!= null)
            {
                foreach (Specie item in this.SpecieList)
                {
                    if(item.Equals(pSpecie))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }            
            return lReturn;
        }

        /// <summary>
        /// Return the Specie added to the list.
        /// If already exists, it return the one of the list.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecieCycle"></param>
        /// <param name="pBaseTemperature"></param>
        /// <returns></returns>
        public Specie AddSpecie(String pName, String pSpecieCycleName, 
                                Double pBaseTemperature, Double pStressTemperarute)
        {
            Specie lReturn = null;
            long lSpecieId = this.SpecieList.Count();
            SpecieCycle lSpecieCycle = null;
            Specie lSpecie = null;

            lSpecieCycle = this.FindSpecieCycle(pSpecieCycleName);
            if(lSpecieCycle == null)
            {
                lSpecieCycle = AddSpecieCycle(pSpecieCycleName);
            }
            lSpecie = new Specie(lSpecieId, pName, lSpecieCycle.SpecieCycleId, 
                                        pBaseTemperature, pStressTemperarute);
            lReturn = this.ExistSpecie(lSpecie);
            if(lReturn == null)
            {
                this.SpecieList.Add(lSpecie);
                lReturn = lSpecie;
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Specie updated in the list.
        /// If not exists, it return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecieCycleName"></param>
        /// <param name="pBaseTemperature"></param>
        /// <returns></returns>
        public Specie UpdateSpecie(String pName, String pSpecieCycleName,
                                    Double pBaseTemperature, Double pStressTemperature)
        {
            Specie lReturn = null;
            SpecieCycle lSpecieCycle = null;
            Specie lSpecie = null;

            lSpecieCycle = this.FindSpecieCycle(pSpecieCycleName);
            if (lSpecieCycle == null)
            {
                lSpecieCycle = AddSpecieCycle(pSpecieCycleName);
            }
            lSpecie = new Specie(0, pName, lSpecieCycle.SpecieCycleId,
                                        pBaseTemperature, pStressTemperature);
            lReturn = ExistSpecie(lSpecie);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.SpecieCycle = lSpecieCycle;
                lReturn.BaseTemperature = pBaseTemperature;
                lReturn.StressTemperature = pStressTemperature;
            }
            return lReturn;
        }

        #endregion

        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Region lRegion = obj as Region;
            return this.Name.Equals(lRegion.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion
    }
}