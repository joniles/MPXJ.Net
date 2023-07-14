using System;
using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class Resource : AbstractFieldContainer, IProjectEntityWithID, IChildResourceContainer, IJavaObjectProxy<net.sf.mpxj.Resource>
    {
        public new net.sf.mpxj.Resource JavaObject => (net.sf.mpxj.Resource)base.JavaObject;

        internal Resource(ProxyManager proxyManager, net.sf.mpxj.Resource javaObject) : base(proxyManager, javaObject) { }

        public Resource AddResource() => _proxyManager.ProxyObject(JavaObject.addResource());

        public void AddChildResource(Resource child) => JavaObject.addChildResource(child.JavaObject);

        public IList<Resource> ChildResources => _proxyManager.ProxyList<net.sf.mpxj.Resource, Resource>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildResources());

        public void AddResourceAssignment(ResourceAssignment assignment) => JavaObject.addResourceAssignment(assignment.JavaObject);

        public IList<ResourceAssignment> TaskAssignments => _proxyManager.ProxyList<net.sf.mpxj.ResourceAssignment, ResourceAssignment>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTaskAssignments());

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public ResourceType? Type
        {
            get => JavaObject.getType().ConvertType();
            set => JavaObject.setType(value.ConvertType());
        }

        public bool Null => JavaObject.getNull();

        public string Initials
        {
            get => JavaObject.getInitials();
            set => JavaObject.setInitials(value);
        }

        public string Phonetics
        {
            get => JavaObject.getPhonetics();
            set => JavaObject.setPhonetics(value);
        }

        public string NtAccount
        {
            get => JavaObject.getNtAccount();
            set => JavaObject.setNtAccount(value);
        }

        public string MaterialLabel
        {
            get => JavaObject.getMaterialLabel();
            set => JavaObject.setMaterialLabel(value);
        }

        public string Code
        {
            get => JavaObject.getCode();
            set => JavaObject.setCode(value);
        }

        public string Group
        {
            get => JavaObject.getGroup();
            set => JavaObject.setGroup(value);
        }

        public net.sf.mpxj.WorkGroup WorkGroup
        {
            get => JavaObject.getWorkGroup();
            set => JavaObject.setWorkGroup(value);
        }

        public string EmailAddress
        {
            get => JavaObject.getEmailAddress();
            set => JavaObject.setEmailAddress(value);
        }

        public string Hyperlink
        {
            get => JavaObject.getHyperlink();
            set => JavaObject.setHyperlink(value);
        }

        public string HyperlinkAddress
        {
            get => JavaObject.getHyperlinkAddress();
            set => JavaObject.setHyperlinkAddress(value);
        }

        public string HyperlinkSubAddress
        {
            get => JavaObject.getHyperlinkSubAddress();
            set => JavaObject.setHyperlinkSubAddress(value);
        }

        public string HyperlinkScreenTip
        {
            get => JavaObject.getHyperlinkScreenTip();
            set => JavaObject.setHyperlinkScreenTip(value);
        }

        public java.lang.Number MaxUnits
        {
            get => JavaObject.getMaxUnits();
            set => JavaObject.setMaxUnits(value);
        }

        public java.lang.Number PeakUnits
        {
            get => JavaObject.getPeakUnits();
            set => JavaObject.setPeakUnits(value);
        }

        public bool OverAllocated
        {
            get => JavaObject.getOverAllocated();
            set => JavaObject.setOverAllocated(value);
        }

        public java.time.LocalDateTime AvailableFrom
        {
            get => JavaObject.getAvailableFrom();
            set => JavaObject.setAvailableFrom(value);
        }

        public java.time.LocalDateTime AvailableTo
        {
            get => JavaObject.getAvailableTo();
            set => JavaObject.setAvailableTo(value);
        }

        public java.time.LocalDateTime Start => JavaObject.getStart();

        public java.time.LocalDateTime Finish => JavaObject.getFinish();

        public bool CanLevel
        {
            get => JavaObject.getCanLevel();
            set => JavaObject.setCanLevel(value);
        }

        public AccrueType? AccrueAt
        {
            get => JavaObject.getAccrueAt().ConvertType();
            set => JavaObject.setAccrueAt(value.ConvertType());
        }

        public net.sf.mpxj.Duration Work
        {
            get => JavaObject.getWork();
            set => JavaObject.setWork(value);
        }

        public net.sf.mpxj.Duration RegularWork
        {
            get => JavaObject.getRegularWork();
            set => JavaObject.setRegularWork(value);
        }

        public net.sf.mpxj.Duration ActualWork
        {
            get => JavaObject.getActualWork();
            set => JavaObject.setActualWork(value);
        }

        public net.sf.mpxj.Duration OvertimeWork
        {
            get => JavaObject.getOvertimeWork();
            set => JavaObject.setOvertimeWork(value);
        }

        public net.sf.mpxj.Duration RemainingWork
        {
            get => JavaObject.getRemainingWork();
            set => JavaObject.setRemainingWork(value);
        }

        public net.sf.mpxj.Duration ActualOvertimeWork
        {
            get => JavaObject.getActualOvertimeWork();
            set => JavaObject.setActualOvertimeWork(value);
        }

        public net.sf.mpxj.Duration RemainingOvertimeWork
        {
            get => JavaObject.getRemainingOvertimeWork();
            set => JavaObject.setRemainingOvertimeWork(value);
        }

        public java.lang.Number PercentWorkComplete
        {
            get => JavaObject.getPercentWorkComplete();
            set => JavaObject.setPercentWorkComplete(value);
        }

        public Rate StandardRate => _proxyManager.ProxyObject(JavaObject.getStandardRate());

        public java.lang.Number Cost
        {
            get => JavaObject.getCost();
            set => JavaObject.setCost(value);
        }

        public Rate OvertimeRate => _proxyManager.ProxyObject(JavaObject.getOvertimeRate());

        public java.lang.Number OvertimeCost
        {
            get => JavaObject.getOvertimeCost();
            set => JavaObject.setOvertimeCost(value);
        }

        public java.lang.Number CostPerUse => JavaObject.getCostPerUse();

        public java.lang.Number ActualCost
        {
            get => JavaObject.getActualCost();
            set => JavaObject.setActualCost(value);
        }

        public java.lang.Number ActualOvertimeCost
        {
            get => JavaObject.getActualOvertimeCost();
            set => JavaObject.setActualOvertimeCost(value);
        }

        public java.lang.Number RemainingCost
        {
            get => JavaObject.getRemainingCost();
            set => JavaObject.setRemainingCost(value);
        }

        public java.lang.Number RemainingOvertimeCost
        {
            get => JavaObject.getRemainingOvertimeCost();
            set => JavaObject.setRemainingOvertimeCost(value);
        }

        public net.sf.mpxj.Duration WorkVariance
        {
            get => JavaObject.getWorkVariance();
            set => JavaObject.setWorkVariance(value);
        }

        public java.lang.Number CostVariance
        {
            get => JavaObject.getCostVariance();
            set => JavaObject.setCostVariance(value);
        }

        public java.lang.Number SV
        {
            get => JavaObject.getSV();
            set => JavaObject.setSV(value);
        }

        public java.lang.Number CV
        {
            get => JavaObject.getCV();
            set => JavaObject.setCV(value);
        }

        public java.lang.Number ACWP
        {
            get => JavaObject.getACWP();
            set => JavaObject.setACWP(value);
        }

        public string Notes
        {
            get => JavaObject.getNotes();
            set => JavaObject.setNotes(value);
        }

        public Notes NotesObject
        {
            get => _proxyManager.ProxyObject(JavaObject.getNotesObject());
            set => JavaObject.setNotesObject(value.JavaObject);
        }

        public java.lang.Number BCWS
        {
            get => JavaObject.getBCWS();
            set => JavaObject.setBCWS(value);
        }

        public java.lang.Number BCWP
        {
            get => JavaObject.getBCWP();
            set => JavaObject.setBCWP(value);
        }

        public bool Generic
        {
            get => JavaObject.getGeneric();
            set => JavaObject.setGeneric(value);
        }

        public bool Active
        {
            get => JavaObject.getActive();
            set => JavaObject.setActive(value);
        }

        public string ActiveDirectoryGUID
        {
            get => JavaObject.getActiveDirectoryGUID();
            set => JavaObject.setActiveDirectoryGUID(value);
        }

        public net.sf.mpxj.Duration ActualOvertimeWorkProtected
        {
            get => JavaObject.getActualOvertimeWorkProtected();
            set => JavaObject.setActualOvertimeWorkProtected(value);
        }

        public net.sf.mpxj.Duration ActualWorkProtected
        {
            get => JavaObject.getActualWorkProtected();
            set => JavaObject.setActualWorkProtected(value);
        }

        public net.sf.mpxj.BookingType BookingType
        {
            get => JavaObject.getBookingType();
            set => JavaObject.setBookingType(value);
        }

        public java.time.LocalDateTime CreationDate
        {
            get => JavaObject.getCreationDate();
            set => JavaObject.setCreationDate(value);
        }

        public bool Enterprise
        {
            get => JavaObject.getEnterprise();
            set => JavaObject.setEnterprise(value);
        }

        public java.lang.Integer CalendarUniqueID
        {
            get => JavaObject.getCalendarUniqueID();
            set => JavaObject.setCalendarUniqueID(value);
        }

        public ProjectCalendar Calendar
        {
            get => _proxyManager.ProxyObject(JavaObject.getCalendar());
            set => JavaObject.setCalendar(value.JavaObject);
        }

        public ProjectCalendar AddCalendar() => _proxyManager.ProxyObject(JavaObject.addCalendar());

        public void SetText(int index, string value) => JavaObject.setText(index, value);

        public string GetText(int index) => JavaObject.getText(index);

        public string BaseCalendar
        {
            get => JavaObject.getBaseCalendar();
            set => JavaObject.setBaseCalendar(value);
        }

        public java.lang.Number BaselineCost
        {
            get => JavaObject.getBaselineCost();
            set => JavaObject.setBaselineCost(value);
        }

        public net.sf.mpxj.Duration BaselineWork
        {
            get => JavaObject.getBaselineWork();
            set => JavaObject.setBaselineWork(value);
        }

        public java.lang.Integer ID
        {
            get => JavaObject.getID();
            set => JavaObject.setID(value);
        }

        public bool LinkedFields
        {
            get => JavaObject.getLinkedFields();
            set => JavaObject.setLinkedFields(value);
        }

        public java.lang.Integer Objects
        {
            get => JavaObject.getObjects();
            set => JavaObject.setObjects(value);
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public java.lang.Integer ParentResourceUniqueID
        {
            get => JavaObject.getParentResourceUniqueID();
            set => JavaObject.setParentResourceUniqueID(value);
        }

        public Resource ParentResource
        {
            get => _proxyManager.ProxyObject(JavaObject.getParentResource());
            set => JavaObject.setParentResource(value.JavaObject);
        }

        public void SetStart(int index, java.time.LocalDateTime value) => JavaObject.setStart(index, value);

        public java.time.LocalDateTime GetStart(int index) => JavaObject.getStart(index);

        public void SetFinish(int index, java.time.LocalDateTime value) => JavaObject.setFinish(index, value);

        public java.time.LocalDateTime GetFinish(int index) => JavaObject.getFinish(index);

        public void SetNumber(int index, java.lang.Number value) => JavaObject.setNumber(index, value);

        public java.lang.Number GetNumber(int index) => JavaObject.getNumber(index);

        public void SetDuration(int index, net.sf.mpxj.Duration value) => JavaObject.setDuration(index, value);

        public net.sf.mpxj.Duration GetDuration(int index) => JavaObject.getDuration(index);

        public void SetDate(int index, java.time.LocalDateTime value) => JavaObject.setDate(index, value);

        public java.time.LocalDateTime GetDate(int index) => JavaObject.getDate(index);

        public void SetCost(int index, java.lang.Number value) => JavaObject.setCost(index, value);

        public java.lang.Number GetCost(int index) => JavaObject.getCost(index);

        public void SetFlag(int index, bool value) => JavaObject.setFlag(index, value);

        public bool GetFlag(int index) => JavaObject.getFlag(index);

        public void SetOutlineCode(int index, string value) => JavaObject.setOutlineCode(index, value);

        public string GetOutlineCode(int index) => JavaObject.getOutlineCode(index);

        public void Remove() => JavaObject.remove();

        public object GetFieldByAlias(string alias) => _proxyManager.GenericProxyObject(JavaObject.getFieldByAlias(alias));

        // TODO proxy arg
        public void SetFieldByAlias(string alias, object value) => JavaObject.setFieldByAlias(alias, value);

        public java.lang.Integer SubprojectResourceUniqueID
        {
            get => JavaObject.getSubprojectResourceUniqueID();
            set => JavaObject.setSubprojectResourceUniqueID(value);
        }

        public java.lang.Number GetEnterpriseCost(int index) => JavaObject.getEnterpriseCost(index);

        public void SetEnterpriseCost(int index, java.lang.Number value) => JavaObject.setEnterpriseCost(index, value);

        public java.time.LocalDateTime GetEnterpriseDate(int index) => JavaObject.getEnterpriseDate(index);

        public void SetEnterpriseDate(int index, java.time.LocalDateTime value) => JavaObject.setEnterpriseDate(index, value);

        public net.sf.mpxj.Duration GetEnterpriseDuration(int index) => JavaObject.getEnterpriseDuration(index);

        public void SetEnterpriseDuration(int index, net.sf.mpxj.Duration value) => JavaObject.setEnterpriseDuration(index, value);

        public bool GetEnterpriseFlag(int index) => JavaObject.getEnterpriseFlag(index);

        public void SetEnterpriseFlag(int index, bool value) => JavaObject.setEnterpriseFlag(index, value);

        public java.lang.Number GetEnterpriseNumber(int index) => JavaObject.getEnterpriseNumber(index);

        public void SetEnterpriseNumber(int index, java.lang.Number value) => JavaObject.setEnterpriseNumber(index, value);

        public string GetEnterpriseText(int index) => JavaObject.getEnterpriseText(index);

        public void SetEnterpriseText(int index, string value) => JavaObject.setEnterpriseText(index, value);

        public void SetBaselineCost(int baselineNumber, java.lang.Number value) => JavaObject.setBaselineCost(baselineNumber, value);

        public void SetBaselineWork(int baselineNumber, net.sf.mpxj.Duration value) => JavaObject.setBaselineWork(baselineNumber, value);

        public java.lang.Number GetBaselineCost(int baselineNumber) => JavaObject.getBaselineCost(baselineNumber);

        public net.sf.mpxj.Duration GetBaselineWork(int baselineNumber) => JavaObject.getBaselineWork(baselineNumber);

        public bool Budget
        {
            get => JavaObject.getBudget();
            set => JavaObject.setBudget(value);
        }

        public Guid? GUID
        {
            get => JavaObject.getGUID().FromJava();
            set => JavaObject.setGUID(value.ToJava());
        }

        public string Unit
        {
            get => JavaObject.getUnit();
            set => JavaObject.setUnit(value);
        }

        public string SupplyReference
        {
            get => JavaObject.getSupplyReference();
            set => JavaObject.setSupplyReference(value);
        }

        public string Description
        {
            get => JavaObject.getDescription();
            set => JavaObject.setDescription(value);
        }

        public string ResourceID
        {
            get => JavaObject.getResourceID();
            set => JavaObject.setResourceID(value);
        }

        public bool ModifyOnIntegrate
        {
            get => JavaObject.getModifyOnIntegrate();
            // TODO: fix in 12.0.1
            /* set => JavaObject.setModifyOnIntegrate(value);*/
        }

        public bool ExpensesOnly
        {
            get => JavaObject.getExpensesOnly();
            // TODO: fix in 12.0.1
            /*set => JavaObject.setExpensesOnly(value); */
        }

        public java.lang.Number PeriodDur
        {
            get => JavaObject.getPeriodDur();
            set => JavaObject.setPeriodDur(value);
        }

        public java.lang.Number Priority
        {
            get => JavaObject.getPriority();
            set => JavaObject.setPriority(value);
        }

        public java.lang.Number Rate
        {
            get => JavaObject.getRate();
            set => JavaObject.setRate(value);
        }

        public java.lang.Number Pool
        {
            get => JavaObject.getPool();
            set => JavaObject.setPool(value);
        }

        public java.lang.Number PerDay
        {
            get => JavaObject.getPerDay();
            set => JavaObject.setPerDay(value);
        }

        public string Phone
        {
            get => JavaObject.getPhone();
            set => JavaObject.setPhone(value);
        }

        public bool Role
        {
            get => JavaObject.getRole();
            // TODO: fix in 12.0.1
            /* set => JavaObject.setRole(value); */
        }

        public void SetCostRateTable(int index, CostRateTable crt) => JavaObject.setCostRateTable(index, crt.JavaObject);

        public CostRateTable GetCostRateTable(int index) => _proxyManager.ProxyObject(JavaObject.getCostRateTable(index));

        public CostRateTableEntry GetCurrentCostRateTableEntry(int costRateTable) => _proxyManager.ProxyObject(JavaObject.getCurrentCostRateTableEntry(costRateTable));

        public AvailabilityTable Availability => _proxyManager.ProxyObject(JavaObject.getAvailability());

        public java.lang.Number BudgetCost
        {
            get => JavaObject.getBudgetCost();
            set => JavaObject.setBudgetCost(value);
        }

        public net.sf.mpxj.Duration BudgetWork
        {
            get => JavaObject.getBudgetWork();
            set => JavaObject.setBudgetWork(value);
        }

        public java.lang.Number BaselineBudgetCost
        {
            get => JavaObject.getBaselineBudgetCost();
            set => JavaObject.setBaselineBudgetCost(value);
        }

        public net.sf.mpxj.Duration BaselineBudgetWork
        {
            get => JavaObject.getBaselineBudgetWork();
            set => JavaObject.setBaselineBudgetWork(value);
        }

        public java.lang.Number GetBaselineBudgetCost(int baselineNumber) => JavaObject.getBaselineBudgetCost(baselineNumber);

        public void SetBaselineBudgetCost(int baselineNumber, java.lang.Number value) => JavaObject.setBaselineBudgetCost(baselineNumber, value);

        public net.sf.mpxj.Duration GetBaselineBudgetWork(int baselineNumber) => JavaObject.getBaselineBudgetWork(baselineNumber);

        public void SetBaselineBudgetWork(int baselineNumber, net.sf.mpxj.Duration value) => JavaObject.setBaselineBudgetWork(baselineNumber, value);

        public string CostCenter
        {
            get => JavaObject.getCostCenter();
            set => JavaObject.setCostCenter(value);
        }

        public bool CalculateCostsFromUnits
        {
            get => JavaObject.getCalculateCostsFromUnits();
            set => JavaObject.setCalculateCostsFromUnits(value);
        }

        public java.lang.Integer SequenceNumber
        {
            get => JavaObject.getSequenceNumber();
            set => JavaObject.setSequenceNumber(value);
        }

        public java.lang.Integer LocationUniqueID
        {
            get => JavaObject.getLocationUniqueID();
            set => JavaObject.setLocationUniqueID(value);
        }

        public Location Location
        {
            get => _proxyManager.ProxyObject(JavaObject.getLocation());
            set => JavaObject.setLocation(value.JavaObject);
        }
    }
}
