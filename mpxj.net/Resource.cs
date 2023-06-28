﻿namespace org.mpxj;

public class Resource
{
    internal readonly ProjectFile _projectFile;
    internal readonly net.sf.mpxj.Resource _proxy;

    internal Resource(ProjectFile projectFile, net.sf.mpxj.Resource proxy)
	{
        _projectFile = projectFile;
        _proxy = proxy;
	}

    public Resource AddResource()
    {
        return _projectFile.ProxyObject(_proxy.addResource(), r => new Resource(_projectFile, r));
    }

    public void AddChildResource(Resource child)
    {
        _proxy.addChildResource(child._proxy);
    }

    public java.util.List ChildResources
    {
        get => _proxy.getChildResources();
    }


    public string Name
    {
        get => _proxy.getName();
        set => _proxy.setName(value);
    }

    public net.sf.mpxj.ResourceType Type
    {
        get => _proxy.getType();
        set => _proxy.setType(value);
    }

    public bool Null
    {
        get => _proxy.getNull();
    }

    public string Initials
    {
        get => _proxy.getInitials();
        set => _proxy.setInitials(value);
    }

    public string Phonetics
    {
        get => _proxy.getPhonetics();
        set => _proxy.setPhonetics(value);
    }

    public string NtAccount
    {
        get => _proxy.getNtAccount();
        set => _proxy.setNtAccount(value);
    }

    public string MaterialLabel
    {
        get => _proxy.getMaterialLabel();
        set => _proxy.setMaterialLabel(value);
    }

    public string Code
    {
        get => _proxy.getCode();
        set => _proxy.setCode(value);
    }

    public string Group
    {
        get => _proxy.getGroup();
        set => _proxy.setGroup(value);
    }

    public net.sf.mpxj.WorkGroup WorkGroup
    {
        get => _proxy.getWorkGroup();
        set => _proxy.setWorkGroup(value);
    }

    public string EmailAddress
    {
        get => _proxy.getEmailAddress();
        set => _proxy.setEmailAddress(value);
    }

    public string Hyperlink
    {
        get => _proxy.getHyperlink();
        set => _proxy.setHyperlink(value);
    }

    public string HyperlinkAddress
    {
        get => _proxy.getHyperlinkAddress();
        set => _proxy.setHyperlinkAddress(value);
    }

    public string HyperlinkSubAddress
    {
        get => _proxy.getHyperlinkSubAddress();
        set => _proxy.setHyperlinkSubAddress(value);
    }

    public string HyperlinkScreenTip
    {
        get => _proxy.getHyperlinkScreenTip();
        set => _proxy.setHyperlinkScreenTip(value);
    }

    public java.lang.Number MaxUnits
    {
        get => _proxy.getMaxUnits();
        set => _proxy.setMaxUnits(value);
    }

    public java.lang.Number PeakUnits
    {
        get => _proxy.getPeakUnits();
        set => _proxy.setPeakUnits(value);
    }

    public bool OverAllocated
    {
        get => _proxy.getOverAllocated();
        set => _proxy.setOverAllocated(value);
    }

    public java.util.Date AvailableFrom
    {
        get => _proxy.getAvailableFrom();
        set => _proxy.setAvailableFrom(value);
    }

    public java.util.Date AvailableTo
    {
        get => _proxy.getAvailableTo();
        set => _proxy.setAvailableTo(value);
    }

    public java.util.Date Start
    {
        get => _proxy.getStart();
    }

    public java.util.Date Finish
    {
        get => _proxy.getFinish();
    }

    public bool CanLevel
    {
        get => _proxy.getCanLevel();
        set => _proxy.setCanLevel(value);
    }

    public net.sf.mpxj.AccrueType AccrueAt
    {
        get => _proxy.getAccrueAt();
        set => _proxy.setAccrueAt(value);
    }

    public net.sf.mpxj.Duration Work
    {
        get => _proxy.getWork();
        set => _proxy.setWork(value);
    }

    public net.sf.mpxj.Duration RegularWork
    {
        get => _proxy.getRegularWork();
        set => _proxy.setRegularWork(value);
    }

    public net.sf.mpxj.Duration ActualWork
    {
        get => _proxy.getActualWork();
        set => _proxy.setActualWork(value);
    }

    public net.sf.mpxj.Duration OvertimeWork
    {
        get => _proxy.getOvertimeWork();
        set => _proxy.setOvertimeWork(value);
    }

    public net.sf.mpxj.Duration RemainingWork
    {
        get => _proxy.getRemainingWork();
        set => _proxy.setRemainingWork(value);
    }

    public net.sf.mpxj.Duration ActualOvertimeWork
    {
        get => _proxy.getActualOvertimeWork();
        set => _proxy.setActualOvertimeWork(value);
    }

    public net.sf.mpxj.Duration RemainingOvertimeWork
    {
        get => _proxy.getRemainingOvertimeWork();
        set => _proxy.setRemainingOvertimeWork(value);
    }

    public java.lang.Number PercentWorkComplete
    {
        get => _proxy.getPercentWorkComplete();
        set => _proxy.setPercentWorkComplete(value);
    }

    public net.sf.mpxj.Rate StandardRate
    {
        get => _proxy.getStandardRate();
    }

    public java.lang.Number Cost
    {
        get => _proxy.getCost();
        set => _proxy.setCost(value);
    }

    public net.sf.mpxj.Rate OvertimeRate
    {
        get => _proxy.getOvertimeRate();
    }

    public java.lang.Number OvertimeCost
    {
        get => _proxy.getOvertimeCost();
        set => _proxy.setOvertimeCost(value);
    }

    public java.lang.Number CostPerUse
    {
        get => _proxy.getCostPerUse();
    }

    public java.lang.Number ActualCost
    {
        get => _proxy.getActualCost();
        set => _proxy.setActualCost(value);
    }

    public java.lang.Number ActualOvertimeCost
    {
        get => _proxy.getActualOvertimeCost();
        set => _proxy.setActualOvertimeCost(value);
    }

    public java.lang.Number RemainingCost
    {
        get => _proxy.getRemainingCost();
        set => _proxy.setRemainingCost(value);
    }

    public java.lang.Number RemainingOvertimeCost
    {
        get => _proxy.getRemainingOvertimeCost();
        set => _proxy.setRemainingOvertimeCost(value);
    }

    public net.sf.mpxj.Duration WorkVariance
    {
        get => _proxy.getWorkVariance();
        set => _proxy.setWorkVariance(value);
    }

    public java.lang.Number CostVariance
    {
        get => _proxy.getCostVariance();
        set => _proxy.setCostVariance(value);
    }

    public java.lang.Number SV
    {
        get => _proxy.getSV();
        set => _proxy.setSV(value);
    }

    public java.lang.Number CV
    {
        get => _proxy.getCV();
        set => _proxy.setCV(value);
    }

    public java.lang.Number ACWP
    {
        get => _proxy.getACWP();
        set => _proxy.setACWP(value);
    }

    public string Notes
    {
        get => _proxy.getNotes();
        set => _proxy.setNotes(value);
    }

    public net.sf.mpxj.Notes NotesObject
    {
        get => _proxy.getNotesObject();
        set => _proxy.setNotesObject(value);
    }

    public java.lang.Number BCWS
    {
        get => _proxy.getBCWS();
        set => _proxy.setBCWS(value);
    }

    public java.lang.Number BCWP
    {
        get => _proxy.getBCWP();
        set => _proxy.setBCWP(value);
    }

    public bool Generic
    {
        get => _proxy.getGeneric();
        set => _proxy.setGeneric(value);
    }

    public bool Active
    {
        get => _proxy.getActive();
        set => _proxy.setActive(value);
    }

    public string ActiveDirectoryGUID
    {
        get => _proxy.getActiveDirectoryGUID();
        set => _proxy.setActveDirectoryGUID(value);
    }

    public net.sf.mpxj.Duration ActualOvertimeWorkProtected
    {
        get => _proxy.getActualOvertimeWorkProtected();
        set => _proxy.setActualOvertimeWorkProtected(value);
    }

    public net.sf.mpxj.Duration ActualWorkProtected
    {
        get => _proxy.getActualWorkProtected();
        set => _proxy.setActualWorkProtected(value);
    }

    public net.sf.mpxj.BookingType BookingType
    {
        get => _proxy.getBookingType();
        set => _proxy.setBookingType(value);
    }

    public java.util.Date CreationDate
    {
        get => _proxy.getCreationDate();
        set => _proxy.setCreationDate(value);
    }

    public bool Enterprise
    {
        get => _proxy.getEnterprise();
        set => _proxy.setEnterprise(value);
    }

    public java.lang.Integer CalendarUniqueID
    {
        get => _proxy.getCalendarUniqueID();
        set => _proxy.setCalendarUniqueID(value);
    }

    public ProjectCalendar Calendar
    {
        get => _projectFile.ProxyObject(_proxy.getCalendar(), c => new ProjectCalendar(_projectFile, c));
        set => _proxy.setCalendar(value._proxy);
    }

    public ProjectCalendar AddCalendar()
    {
        return _projectFile.ProxyObject(_proxy.addCalendar(), c => new ProjectCalendar(_projectFile, c));
    }

    public void SetText(int index, string value)
    {
        _proxy.setText(index, value);
    }

    public string GetText(int index)
    {
        return _proxy.getText(index);
    }

    public string BaseCalendar
    {
        get => _proxy.getBaseCalendar();
        set => _proxy.setBaseCalendar(value);
    }

    public java.lang.Number BaselineCost
    {
        get => _proxy.getBaselineCost();
        set => _proxy.setBaselineCost(value);
    }

    public net.sf.mpxj.Duration BaselineWork
    {
        get => _proxy.getBaselineWork();
        set => _proxy.setBaselineWork(value);
    }

    public java.lang.Integer ID
    {
        get => _proxy.getID();
        set => _proxy.setID(value);
    }

    public bool LinkedFields
    {
        get => _proxy.getLinkedFields();
        set => _proxy.setLinkedFields(value);
    }

    public java.lang.Integer Objects
    {
        get => _proxy.getObjects();
        set => _proxy.setObjects(value);
    }

    public java.lang.Integer UniqueID
    {
        get => _proxy.getUniqueID();
        set => _proxy.setUniqueID(value);
    }

    public java.lang.Integer ParentResourceUniqueID
    {
        get => _proxy.getParentResourceUniqueID();
        set => _proxy.setParentResourceUniqueID(value);
    }

    public Resource ParentResource
    {
        get => _projectFile.ProxyObject(_proxy.getParentResource(), r => new Resource(_projectFile, r));
        set => _proxy.setParentResource(value._proxy);
    }

    public void SetStart(int index, java.util.Date value)
    {
        _proxy.setStart(index, value);
    }

    public java.util.Date GetStart(int index)
    {
        return _proxy.getStart(index);
    }

    void setFinish(int index, java.util.Date value);

    java.util.Date getFinish(int index);

    void setNumber(int index, java.lang.Number value);

    java.lang.Number getNumber(int index);

    void setDuration(int index, net.sf.mpxj.Duration value);

    net.sf.mpxj.Duration getDuration(int index);

    void setDate(int index, java.util.Date value);

    java.util.Date getDate(int index);

    void setCost(int index, java.lang.Number value);

    java.lang.Number getCost(int index);

    void setFlag(int index, bool value);

    bool getFlag(int index);

    void setOutlineCode(int index, string value);

    string getOutlineCode(int index);

    public void Remove()
    {
        _proxy.remove();
    }

    public object GetFieldByAlias(string alias)
    {
        // TODO: proxy the result
        return _proxy.getFieldByAlias(alias);
    }

    public java.util.List TaskAssignments
    {
        get => _proxy.getTaskAssignments();
    }

    public java.lang.Integer SubprojectResourceUniqueID
    {
        get => _proxy.getSubprojectResourceUniqueID();
        set => _proxy.setSubprojectResourceUniqueID(value);
    }

    java.lang.Number getEnterpriseCost(int index);

    void setEnterpriseCost(int index, java.lang.Number value);

    java.util.Date getEnterpriseDate(int index);

    void setEnterpriseDate(int index, java.util.Date value);

    net.sf.mpxj.Duration getEnterpriseDuration(int index);

    void setEnterpriseDuration(int index, net.sf.mpxj.Duration value);

    bool getEnterpriseFlag(int index);

    void setEnterpriseFlag(int index, bool value);

    java.lang.Number getEnterpriseNumber(int index);

    void setEnterpriseNumber(int index, java.lang.Number value);

    string getEnterpriseText(int index);

    void setEnterpriseText(int index, string value);

    void setBaselineCost(int baselineNumber, java.lang.Number value);

    void setBaselineWork(int baselineNumber, net.sf.mpxj.Duration value);

    java.lang.Number getBaselineCost(int baselineNumber);

    net.sf.mpxj.Duration getBaselineWork(int baselineNumber);

    public bool Budget
    {
        get => _proxy.getBudget();
        set => _proxy.setBudget(value);
    }

    public java.util.UUID GUID
    {
        get => _proxy.getGUID();
        set => _proxy.setGUID(value);
    }

    public string Unit
    {
        get => _proxy.getUnit();
        set => _proxy.setUnit(value);
    }

    public string SupplyReference
    {
        get => _proxy.getSupplyReference();
        set => _proxy.setSupplyReference(value);
    }

    public string Description
    {
        get => _proxy.getDescription();
        set => _proxy.setDescription(value);
    }

    public string ResourceID
    {
        get => _proxy.getResourceID();
        set => _proxy.setResourceID(value);
    }

    public bool ModifyOnIntegrate
    {
        get => _proxy.getModifyOnIntegrate();
        set => _proxy.setModifyOnIntegrate(value);
    }

    public bool ExpensesOnly
    {
        get => _proxy.getExpensesOnly();
        set => _proxy.setExpensesOnly(value);
    }

    public java.lang.Number PeriodDur
    {
        get => _proxy.getPeriodDur();
        set => _proxy.setPeriodDur(value);
    }

    public java.lang.Number Priority
    {
        get => _proxy.getPriority();
        set => _proxy.setPriority(value);
    }

    public java.lang.Number Rate
    {
        get => _proxy.getRate();
        set => _proxy.setRate(value);
    }

    public java.lang.Number Pool
    {
        get => _proxy.getPool();
        set => _proxy.setPool(value);
    }

    public java.lang.Number PerDay
    {
        get => _proxy.getPerDay();
        set => _proxy.setPerDay(value);
    }

    public string Phone
    {
        get => _proxy.getPhone();
        set => _proxy.setPhone(value);
    }

    public bool Role
    {
        get => _proxy.getRole();
        set => _proxy.setRole(value);
    }

    void setCostRateTable(int index, CostRateTable crt);

    net.sf.mpxj.CostRateTable getCostRateTable(int index);

    net.sf.mpxj.CostRateTableEntry getCurrentCostRateTableEntry(int costRateTable);

    public net.sf.mpxj.AvailabilityTable Availability();    

    public java.lang.Number BudgetCost
    {
        get => _proxy.getBudgetCost();
        set => _proxy.setBudgetCost(value);
    }

    public net.sf.mpxj.Duration BudgetWork
    {
        get => _proxy.getBudgetWork();
        set => _proxy.setBudgetWork(value);
    }

    public java.lang.Number BaselineBudgetCost
    {
        get => _proxy.getBaselineBudgetCost();
        set => _proxy.setBaselineBudgetCost(value);
    }

    public net.sf.mpxj.Duration BaselineBudgetWork
    {
        get => _proxy.getBaselineBudgetWork();
        set => _proxy.setBaselineBudgetWork(value);
    }

    java.lang.Number getBaselineBudgetCost(int baselineNumber);

    void setBaselineBudgetCost(int baselineNumber, java.lang.Number value);

    net.sf.mpxj.Duration getBaselineBudgetWork(int baselineNumber);

    void setBaselineBudgetWork(int baselineNumber, net.sf.mpxj.Duration value);

    public string CostCenter
    {
        get => _proxy.getCostCenter();
        set => _proxy.setCostCenter(value);
    }

    public bool CalculateCostsFromUnits
    {
        get => _proxy.getCalculateCostsFromUnits();
        set => _proxy.setCalculateCostsFromUnits(value);
    }

    public java.lang.Integer SequenceNumber
    {
        get => _proxy.getSequenceNumber();
        set => _proxy.setSequenceNumber(value);
    }

    public java.lang.Integer LocationUniqueID
    {
        get => _proxy.getLocationUniqueID();
        set => _proxy.setLocationUniqueID(value);
    }

    public net.sf.mpxj.Location Location
    {
        get => _proxy.getLocation();
        set => _proxy.setLocation(value);
    }
}