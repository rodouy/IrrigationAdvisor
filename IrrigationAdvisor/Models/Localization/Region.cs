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
    ///     EffectiveRain
    ///     CropIrrigationWeather
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - idRegion int
    ///     - name String
    ///     - location Location
    ///     - specieList: List<Specie>
    ///     - effectiveRain List <EffectiveRain>
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
        ///     - idRegion: identifier
        ///     - name: the name of the region
        ///     - position: the position of the region
        ///     - specieList: list of the species of the region
        ///     - effectiveRainList: effective rain (by month) for the region
        ///     
        /// </summary>
        private long idRegion;
        private String name;
        private Position position;
        private List<Specie> specieList;
        private List<EffectiveRain> effectiveRainList;

        #endregion

        #region Properties

        public long IdRegion
        {
            get { return idRegion; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Position Position
        {
            get { return position; }
            set { position = value; }
        }

        public List<EffectiveRain> EffectiveRainList
        {
            get { return effectiveRainList; }
            set { effectiveRainList = value; }
        }

        public List<Specie> SpecieList
        {
            get { return specieList; }
            set { specieList = value; }
        }
        
        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Region()
        {
            this.idRegion = 0;
            this.Name = "";
            this.Position = new Position();
            this.EffectiveRainList = new List<EffectiveRain>();
            this.SpecieList = new List<Specie>();
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pIDRegion"></param>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        public Region(long pIDRegion, String pName, Position pPosition)
        {
            this.idRegion = pIDRegion;
            this.Name = pName;
            this.Position = pPosition;
            this.EffectiveRainList = new List<EffectiveRain>();
            this.SpecieList = new List<Specie>(); 
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pIDRegion"></param>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <param name="pEffectiveRainList"></param>
        /// <param name="pSpecieList"></param>
        public Region(long pIDRegion, String pName, Position pPosition, 
                    List<EffectiveRain> pEffectiveRainList,
                    List<Specie> pSpecieList)
        {
            this.idRegion = pIDRegion;
            this.Name = pName;
            this.Position = pPosition;
            this.EffectiveRainList = pEffectiveRainList;
            this.SpecieList = pSpecieList;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// If EffectiveRain exists in List, return the Effective Rain, else null
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
        /// Update the effective rain if exists in List, else return null
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


        /// <summary>
        /// If Specie exists in List return the Specie, else null
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        public Specie ExistSpecie(Specie pSpecie)
        {
            Specie lReturn = null;
            foreach (Specie item in SpecieList)
            {
                if(item.Equals(pSpecie))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }


        public Specie AddSpecie(String pName, Double pBaseTemperature,
                            CropCoefficient pCropCoefficient, 
                            List<PhenologicalStage> pPhenologicalStageList)
        {
            Specie lReturn = null;
            long lIDSpecie = this.SpecieList.Count();
            Specie lSpecie = new Specie(lIDSpecie, pName, pBaseTemperature,
                pCropCoefficient, pPhenologicalStageList);

            return lReturn;
        }

        public Specie UpdateSpecie()
        {
            Specie lReturn = null;
            return lReturn;
        }
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
                //&& this .Position.Equals(pRegion.Position);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion
    }
}