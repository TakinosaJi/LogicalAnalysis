using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Infrastructure;
using Logic.JudgementForms.ApproachForm;
using Logic.JudgementForms.ExistanceForm;
using Logic.JudgementForms.PredicateForm;
using Logic.JudgementForms.SubjectForm;
using Logic.JudgementForms.SubjectPredicateRelationForm;
using Logic.JudgementParts;
using Logic.JudgementTypes.ModalityType;
using Logic.JudgementTypes.QualityType;
using Logic.JudgementTypes.QuantityType;
using Logic.JudgementTypes.RelationType;
using Logic.LogicalSquare;
using General = Logic.JudgementTypes.QuantityType.General;

namespace Logic
{
    public class Judgement
    {
        #region Fields
        private Subject _subject;
        private Predicate _predicate;
        private Copula _copula;

        private Boolean _isTrully;
        
        //Judgement Forms
        private ApproachForm _approachForm;
        private ExistanceForm _existaneForm;
        private SubjectForm _subjectForm;
        private PredicateForm _predicateForm;
        private SubjectPredicateRelationForm _subjectPredicateRelationForm;

        //Judgement Types
        private ModalityType _modalityType;
        private QuantityType _quantityType;
        private QualityType _qualityType;
        private RelationType _relationType;
        //Основа
        private Judgement _ratioCognoscendi;
        //Причина
        private Judgement _ratioFiendi;

        private IEnumerable<Notion> _actualSubjectVolume;
        private IEnumerable<Notion> _actualPredicateVolume; 
        #endregion

        #region Properties 
        public Subject Subject
        {
            get { return _subject; }
        }
        public Predicate Predicate
        {
            get { return _predicate; }
        }
        public Copula Copula
        {
            get { return _copula; }
        }
        public Judgement RatioCognoscendi
        {
            get { return _ratioCognoscendi; }
        }
        public Judgement RatioFiendi
        {
            get { return _ratioFiendi; }
        }
        /// <summary>
        ///Is subject distributed.
        /// </summary>
        public Boolean IsSubjectDistriuted
        {
            get { return ActualSubjectVolume.Count() == Subject.Volume.Count(); }
        }
        /// <summary>
        ///Is predicate distributed.
        /// </summary>
        public Boolean IsPredicateDistriuted
        {
            get { return ActualPredicateVolume.Count() == Predicate.Volume.Count(); }
        }
        /// <summary>
        /// Объем субъекта, который имеется ввиду в суждении.
        /// </summary>
        public IEnumerable<Notion> ActualSubjectVolume
        {
            get { return _actualSubjectVolume; }
        }
        /// <summary>
        /// Объем предиката, который имеется ввиду в суждении.
        /// </summary>
        public IEnumerable<Notion> ActualPredicateVolume
        {
            get { return _actualPredicateVolume; }
        }

        public ApproachForm ApproachForm
        {
            get { return _approachForm; }
        }

        public ExistanceForm ExistaneForm
        {
            get { return _existaneForm; }
        }

        public SubjectForm SubjectForm
        {
            get { return _subjectForm; }
        }

        public PredicateForm PredicateForm
        {
            get { return _predicateForm; }
        }

        public SubjectPredicateRelationForm SubjectPredicateRelationForm
        {
            get { return _subjectPredicateRelationForm; }
        }

        public bool IsTrully
        {
            get { return _isTrully; }
        }

        public ModalityType ModalityType
        {
            get { return _modalityType; }
        }

        public QuantityType QuantityType
        {
            get { return _quantityType; }
        }

        public QualityType QualityType
        {
            get { return _qualityType; }
        }

        public RelationType RelationType
        {
            get { return _relationType; }
        }

        public Boolean A
        {
            get
            {
                return (QuantityType.Type.GetIdent() == (Int32)QuantityTypes.General || 
                        QuantityType.Type.GetIdent() == (Int32)QuantityTypes.Individual)
                         && QualityType.Form.GetIdent() == (Int32)QualityTypes.Affirmative;
            }
        }

        public Boolean I
        {
            get
            {
                return QuantityType.Type.GetIdent() == (Int32)QuantityTypes.Partial
                         && QualityType.Form.GetIdent() == (Int32)QualityTypes.Affirmative;
            }
        }

        public Boolean E
        {
            get
            {
                return (QuantityType.Type.GetIdent() == (Int32)QuantityTypes.General ||
                        QuantityType.Type.GetIdent() == (Int32)QuantityTypes.Individual)
                         && QualityType.Form.GetIdent() == (Int32)QualityTypes.Negative;
            }
        }

        public Boolean O
        {
            get
            {
                return QuantityType.Type.GetIdent() == (Int32)QuantityTypes.Partial
                         && QualityType.Form.GetIdent() == (Int32)QualityTypes.Negative;
            }
        }
        #endregion
        
        #region Constructors
        internal Judgement()
        {
            _approachForm = new ApproachForm();
            _existaneForm = new ExistanceForm();
            _subjectForm = new SubjectForm();
            _predicateForm = new PredicateForm();
            _subjectPredicateRelationForm = new SubjectPredicateRelationForm();

            _modalityType = new ModalityType();
            _quantityType = new QuantityType();
            _qualityType = new QualityType();
            _relationType = new RelationType();
        }
        #endregion

        #region InterfaceImplementation
        #endregion

        #region Methods
        public Type GetJudgementType()
        {
            return GetType();
        }
        public JudgementsRelationResult DetermineRelation(Judgement targetJudgement)
        {
            var result = new JudgementsRelationResult();

            if (A)
            {
                if (targetJudgement.O)
                {
                    result.IsCorrect = true;
                    result.Relation = new ContradictionRelation();
                    result.IsTruthStateOfComparableJudgementCorrect =
                        DefinitionStateFabric.Get(IsTrully != targetJudgement.IsTrully);
                }
                if (targetJudgement.I)
                {
                    result.IsCorrect = true;
                    result.Relation = new SubordinationRelation();
                    result.IsTruthStateOfComparableJudgementCorrect = IsTrully
                        ? DefinitionStateFabric.Get(targetJudgement.IsTrully)
                        : DefinitionState.Undefined;
                }
                if (targetJudgement.E)
                {
                    result.IsCorrect = true;
                    result.Relation = new ContraryRelation();
                    result.IsTruthStateOfComparableJudgementCorrect = IsTrully
                        ? DefinitionStateFabric.Get(!targetJudgement.IsTrully)
                        : DefinitionState.Undefined;
                }
            }
            if (I)
            {
                if (targetJudgement.E)
                {
                    result.IsCorrect = true;
                    result.Relation = new ContradictionRelation();
                    result.IsTruthStateOfComparableJudgementCorrect = DefinitionStateFabric.Get(IsTrully != targetJudgement.IsTrully);
                }
                if (targetJudgement.A)
                {
                    result.IsCorrect = true;
                    result.Relation = new SubordinationRelation();
                    result.IsTruthStateOfComparableJudgementCorrect = IsTrully ? DefinitionState.Undefined : DefinitionStateFabric.Get(!targetJudgement.IsTrully);
                }
                if (targetJudgement.O)
                {
                    result.IsCorrect = true;
                    result.Relation = new SubcontraryRelation();
                    result.IsTruthStateOfComparableJudgementCorrect = IsTrully ? DefinitionState.Undefined : DefinitionStateFabric.Get(targetJudgement.IsTrully);
                }
            }
            if (E)
            {
                if (targetJudgement.I)
                {
                    result.IsCorrect = true;
                    result.Relation = new ContradictionRelation();
                    result.IsTruthStateOfComparableJudgementCorrect = DefinitionStateFabric.Get(IsTrully != targetJudgement.IsTrully);
                }
                if (targetJudgement.O)
                {
                    result.IsCorrect = true;
                    result.Relation = new SubordinationRelation();
                    result.IsTruthStateOfComparableJudgementCorrect = IsTrully ? DefinitionStateFabric.Get(targetJudgement.IsTrully) : DefinitionState.Undefined;
                }
                if (targetJudgement.A)
                {
                    result.IsCorrect = true;
                    result.Relation = new ContraryRelation() { ExtremeContradiction = true };
                    result.IsTruthStateOfComparableJudgementCorrect = IsTrully ? DefinitionStateFabric.Get(!targetJudgement.IsTrully) : DefinitionState.Undefined;
                }
            }
            if (O)
            {
                if (targetJudgement.A)
                {
                    result.IsCorrect = true;
                    result.Relation = new ContradictionRelation();
                    result.IsTruthStateOfComparableJudgementCorrect = DefinitionStateFabric.Get(IsTrully != targetJudgement.IsTrully);
                }
                if (targetJudgement.E)
                {
                    result.IsCorrect = true;
                    result.Relation = new SubordinationRelation();
                    result.IsTruthStateOfComparableJudgementCorrect = IsTrully ? DefinitionState.Undefined : DefinitionStateFabric.Get(!targetJudgement.IsTrully);
                }
                if (targetJudgement.I)
                {
                    result.IsCorrect = true;
                    result.Relation = new SubcontraryRelation();
                    result.IsTruthStateOfComparableJudgementCorrect = IsTrully ? DefinitionState.Undefined : DefinitionStateFabric.Get(targetJudgement.IsTrully);
                }
            }

            return result;
        }

        protected virtual Boolean VerifyJudgement()
        {
            return false;
        }
        #endregion
    }
}

/*      #region Fields
        #endregion
 
        #region Properties
        #endregion

        #region Constructors
        #endregion
 
        #region ClassImplementation
        #endregion
 * 
        #region InterfaceImplementation
        #endregion

        #region Methods
        #endregion
 */