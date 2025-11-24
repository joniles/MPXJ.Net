using MPXJ.Net.Proxy;
using System;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public class Task : AbstractFieldContainer, IProjectEntityWithID, IChildTaskContainer, IJavaObjectProxy<org.mpxj.Task>
    {
        public new org.mpxj.Task JavaObject => (org.mpxj.Task)base.JavaObject;

        internal Task(ProxyManager proxyManager, org.mpxj.Task javaObject) : base(proxyManager, javaObject) { }

        public ProjectFile Parent => _proxyManager.ProxyObject(JavaObject.getParentFile());
        
        public Relation AddPredecessor(Relation.Builder builder) => _proxyManager.ProxyObject(JavaObject.addPredecessor(builder.JavaObject));

        public RecurringTask AddRecurringTask() => _proxyManager.ProxyObject(JavaObject.addRecurringTask());

        public RecurringTask RecurringTask => _proxyManager.ProxyObject(JavaObject.getRecurringTask());
        
        public IDictionary<ActivityCode, ActivityCodeValue> ActivityCodeValues => _proxyManager.ProxyDictionary<org.mpxj.ActivityCode, org.mpxj.ActivityCodeValue, ActivityCode, ActivityCodeValue>(k => _proxyManager.ProxyObject(k), k => k.JavaObject, v => _proxyManager.ProxyObject(v), v => v.JavaObject, JavaObject.getActivityCodeValues());
        
        public void AddActivityCodeValue(ActivityCodeValue value) => JavaObject.addActivityCodeValue(value?.JavaObject);

        public ResourceAssignment AddResourceAssignment(Resource resource) => _proxyManager.ProxyObject(JavaObject.addResourceAssignment(resource?.JavaObject));
        
        public ResourceAssignment GetExistingResourceAssignment(Resource resource) => _proxyManager.ProxyObject(JavaObject.getExistingResourceAssignment(resource.JavaObject));

        public IList<ResourceAssignment> ResourceAssignments => _proxyManager.ProxyList<org.mpxj.ResourceAssignment, ResourceAssignment>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getResourceAssignments());

        public Guid? SubprojectGUID
        {
            get => JavaObject.getSubprojectGUID().ConvertType();
            set => JavaObject.setSubprojectGUID(value.ConvertType());
        }

        public double? PercentageComplete
        {
            get => JavaObject.getPercentageComplete().ConvertType();
            set => JavaObject.setPercentageComplete(value.ConvertType());
        }

        public double? PercentageWorkComplete
        {
            get => JavaObject.getPercentageWorkComplete().ConvertType();
            set => JavaObject.setPercentageWorkComplete(value.ConvertType());
        }

        public double? ActualCost
        {
            get => JavaObject.getActualCost().ConvertType();
            set => JavaObject.setActualCost(value.ConvertType());
        }

        public Duration ActualDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualDuration());
            set => JavaObject.setActualDuration(value?.JavaObject);
        }

        public DateTime? ActualFinish
        {
            get => JavaObject.getActualFinish().ConvertType();
            set => JavaObject.setActualFinish(value.ConvertType());
        }

        public DateTime? ActualStart
        {
            get => JavaObject.getActualStart().ConvertType();
            set => JavaObject.setActualStart(value.ConvertType());
        }

        public Duration ActualWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualWork());
            set => JavaObject.setActualWork(value?.JavaObject);
        }

        public double? BaselineCost
        {
            get => JavaObject.getBaselineCost().ConvertType();
            set => JavaObject.setBaselineCost(value.ConvertType());
        }

        public Duration BaselineDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineDuration());
            set => JavaObject.setBaselineDuration(value?.JavaObject);
        }

        public string BaselineDurationText
        {
            get => JavaObject.getBaselineDurationText();
            set => JavaObject.setBaselineDurationText(value);
        }

        public DateTime? BaselineFinish
        {
            get => JavaObject.getBaselineFinish().ConvertType();
            set => JavaObject.setBaselineFinish(value.ConvertType());
        }

        public string BaselineFinishText
        {
            get => JavaObject.getBaselineFinishText();
            set => JavaObject.setBaselineFinishText(value);
        }

        public DateTime? BaselineStart
        {
            get => JavaObject.getBaselineStart().ConvertType();
            set => JavaObject.setBaselineStart(value.ConvertType());
        }

        public string BaselineStartText
        {
            get => JavaObject.getBaselineStartText();
            set => JavaObject.setBaselineStartText(value);
        }

        public Duration BaselineWork
        {
            get => _proxyManager.ProxyObject(JavaObject?.getBaselineWork());
            set => JavaObject.setBaselineWork(value?.JavaObject);
        }

        public double? BCWP
        {
            get => JavaObject.getBCWP().ConvertType();
            set => JavaObject.setBCWP(value.ConvertType());
        }

        public double? BCWS
        {
            get => JavaObject.getBCWS().ConvertType();
            set => JavaObject.setBCWS(value.ConvertType());
        }

        public bool Confirmed
        {
            get => JavaObject.getConfirmed();
            set => JavaObject.setConfirmed(value);
        }

        public DateTime? ConstraintDate
        {
            get => JavaObject.getConstraintDate().ConvertType();
            set => JavaObject.setConstraintDate(value.ConvertType());
        }

        public DateTime? SecondaryConstraintDate
        {
            get => JavaObject.getSecondaryConstraintDate().ConvertType();
            set => JavaObject.setSecondaryConstraintDate(value.ConvertType());
        }

        public ConstraintType? ConstraintType
        {
            get => JavaObject.getConstraintType().ConvertType();
            set => JavaObject.setConstraintType(value.ConvertType());
        }

        public ConstraintType? SecondaryConstraintType
        {
            get => JavaObject.getSecondaryConstraintType().ConvertType();
            set => JavaObject.setSecondaryConstraintType(value.ConvertType());
        }

        public string Contact
        {
            get => JavaObject.getContact();
            set => JavaObject.setContact(value);
        }

        public double? Cost
        {
            get => JavaObject.getCost().ConvertType();
            set => JavaObject.setCost(value.ConvertType());
        }

        public double? CostVariance
        {
            get => JavaObject.getCostVariance().ConvertType();
            set => JavaObject.setCostVariance(value.ConvertType());
        }

        public DateTime? CreateDate
        {
            get => JavaObject.getCreateDate().ConvertType();
            set => JavaObject.setCreateDate(value.ConvertType());
        }

        public bool Critical
        {
            get => JavaObject.getCritical();
            set => JavaObject.setCritical(value);
        }

        public double? CV
        {
            get => JavaObject.getCV().ConvertType();
            set => JavaObject.setCV(value.ConvertType());
        }

        public Duration LevelingDelay
        {
            get => _proxyManager.ProxyObject(JavaObject?.getLevelingDelay());
            set => JavaObject.setLevelingDelay(value?.JavaObject);
        }

        public Duration Duration
        {
            get => _proxyManager.ProxyObject(JavaObject.getDuration());
            set => JavaObject.setDuration(value?.JavaObject);
        }

        public string DurationText
        {
            get => JavaObject.getDurationText();
            set => JavaObject.setDurationText(value);
        }

        public Duration ManualDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getManualDuration());
            set => JavaObject.setManualDuration(value?.JavaObject);
        }

        public void SetDuration(int index, Duration value) => JavaObject.setDuration(index, value?.JavaObject);

        public Duration GetDuration(int index) => _proxyManager.ProxyObject(JavaObject.getDuration(index));

        public void SetCost(int index, double? value) => JavaObject.setCost(index, value.ConvertType());

        public double? GetCost(int index) => JavaObject.getCost(index).ConvertType();

        public Duration DurationVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getDurationVariance());
            set => JavaObject.setDurationVariance(value?.JavaObject);
        }

        public DateTime? EarlyFinish
        {
            get => JavaObject.getEarlyFinish().ConvertType();
            set => JavaObject.setEarlyFinish(value.ConvertType());
        }

        public DateTime? RemainingEarlyFinish
        {
            get => JavaObject.getRemainingEarlyFinish().ConvertType();
            set => JavaObject.setRemainingEarlyFinish(value.ConvertType());
        }

        public DateTime? EarlyStart
        {
            get => JavaObject.getEarlyStart().ConvertType();
            set => JavaObject.setEarlyStart(value.ConvertType());
        }

        public DateTime? RemainingEarlyStart
        {
            get => JavaObject.getRemainingEarlyStart().ConvertType();
            set => JavaObject.setRemainingEarlyStart(value.ConvertType());
        }

        public DateTime? Finish
        {
            get => JavaObject.getFinish().ConvertType();
            set => JavaObject.setFinish(value.ConvertType());
        }

        public string FinishText
        {
            get => JavaObject.getFinishText();
            set => JavaObject.setFinishText(value);
        }

        public void SetFinish(int index, DateTime value) => JavaObject.setFinish(index, value.ConvertType());

        public DateTime? GetFinish(int index) => JavaObject.getFinish(index).ConvertType();

        public Duration FinishVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getFinishVariance());
            set => JavaObject.setFinishVariance(value?.JavaObject);
        }

        public double? FixedCost
        {
            get => JavaObject.getFixedCost().ConvertType();
            set => JavaObject.setFixedCost(value.ConvertType());
        }

        public void SetFlag(int index, bool value) => JavaObject.setFlag(index, value);

        public bool GetFlag(int index) => JavaObject.getFlag(index);

        public Duration FreeSlack
        {
            get => _proxyManager.ProxyObject(JavaObject.getFreeSlack());
            set => JavaObject.setFreeSlack(value?.JavaObject);
        }

        public bool HideBar
        {
            get => JavaObject.getHideBar();
            set => JavaObject.setHideBar(value);
        }

        public int? ID
        {
            get => JavaObject.getID().ConvertType();
            set => JavaObject.setID(value.ConvertType());
        }

        public DateTime? LateFinish
        {
            get => JavaObject.getLateFinish().ConvertType();
            set => JavaObject.setLateFinish(value.ConvertType());
        }

        public DateTime? RemainingLateFinish
        {
            get => JavaObject.getRemainingLateFinish().ConvertType();
            set => JavaObject.setRemainingLateFinish(value.ConvertType());
        }

        public DateTime? LateStart
        {
            get => JavaObject.getLateStart().ConvertType();
            set => JavaObject.setLateStart(value.ConvertType());
        }

        public DateTime? RemainingLateStart
        {
            get => JavaObject.getRemainingLateStart().ConvertType();
            set => JavaObject.setRemainingLateStart(value.ConvertType());
        }

        public bool LinkedFields
        {
            get => JavaObject.getLinkedFields();
            set => JavaObject.setLinkedFields(value);
        }

        public bool Marked
        {
            get => JavaObject.getMarked();
            set => JavaObject.setMarked(value);
        }

        public bool Milestone
        {
            get => JavaObject.getMilestone();
            set => JavaObject.setMilestone(value);
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public string Notes
        {
            get => JavaObject.getNotes();
            set => JavaObject.setNotes(value);
        }

        public Notes NotesObject
        {
            get => _proxyManager.ProxyObject(JavaObject.getNotesObject());
            set => JavaObject.setNotesObject(value?.JavaObject);
        }

        public Task AddTask() => _proxyManager.ProxyObject(JavaObject.addTask());

        public void RemoveChildTask(Task child) => JavaObject.removeChildTask(child.JavaObject);

        public void SetNumber(int index, double? value) => JavaObject.setNumber(index, value.ConvertType());

        public double? GetNumber(int index) => JavaObject.getNumber(index).ConvertType();

        public int? Objects
        {
            get => JavaObject.getObjects().ConvertType();
            set => JavaObject.setObjects(value.ConvertType());
        }

        public int? OutlineLevel
        {
            get => JavaObject.getOutlineLevel().ConvertType();
            set => JavaObject.setOutlineLevel(value.ConvertType());
        }

        public string OutlineNumber
        {
            get => JavaObject.getOutlineNumber();
            set => JavaObject.setOutlineNumber(value);
        }

        public IList<Relation> Predecessors => _proxyManager.ProxyList<org.mpxj.Relation, Relation>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getPredecessors());

        public IList<Relation> Successors => _proxyManager.ProxyList<org.mpxj.Relation, Relation>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getSuccessors());

        public Priority Priority
        {
            get => _proxyManager.ProxyObject(JavaObject.getPriority());
            set => JavaObject.setPriority(value?.JavaObject);
        }

        public string Project
        {
            get => JavaObject.getProject();
            set => JavaObject.setProject(value);
        }

        public double? RemainingCost
        {
            get => JavaObject.getRemainingCost().ConvertType();
            set => JavaObject.setRemainingCost(value.ConvertType());
        }

        public Duration RemainingDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingDuration());
            set => JavaObject.setRemainingDuration(value?.JavaObject);
        }

        public Duration RemainingWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingWork());
            set => JavaObject.setRemainingWork(value?.JavaObject);
        }

        public string ResourceGroup
        {
            get => JavaObject.getResourceGroup();
            set => JavaObject.setResourceGroup(value);
        }

        public string ResourceInitials
        {
            get => JavaObject.getResourceInitials();
            set => JavaObject.setResourceInitials(value);
        }

        public string ResourceNames
        {
            get => JavaObject.getResourceNames();
            set => JavaObject.setResourceNames(value);
        }

        public DateTime? Resume
        {
            get => JavaObject.getResume().ConvertType();
            set => JavaObject.setResume(value.ConvertType());
        }

        public bool Rollup
        {
            get => JavaObject.getRollup();
            set => JavaObject.setRollup(value);
        }

        public DateTime? Start
        {
            get => JavaObject.getStart().ConvertType();
            set => JavaObject.setStart(value.ConvertType());
        }

        public string StartText
        {
            get => JavaObject.getStartText();
            set => JavaObject.setStartText(value);
        }

        public void SetStart(int index, DateTime value) => JavaObject.setStart(index, value.ConvertType());

        public DateTime? GetStart(int index) => JavaObject.getStart(index).ConvertType();

        public Duration StartVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getStartVariance());
            set => JavaObject.setStartVariance(value?.JavaObject);
        }

        public DateTime? Stop
        {
            get => JavaObject.getStop().ConvertType();
            set => JavaObject.setStop(value.ConvertType());
        }

        public string SubprojectFile
        {
            get => JavaObject.getSubprojectFile();
            set => JavaObject.setSubprojectFile(value);
        }

        public bool Summary
        {
            get => JavaObject.getSummary();
            set => JavaObject.setSummary(value);
        }

        public double? SV
        {
            get => JavaObject.getSV().ConvertType();
            set => JavaObject.setSV(value.ConvertType());
        }

        public void SetText(int index, string value) => JavaObject.setText(index, value);

        public string GetText(int index) => JavaObject.getText(index);

        public void SetOutlineCode(int index, string value) => JavaObject.setOutlineCode(index, value);

        public string GetOutlineCode(int index) => JavaObject.getOutlineCode(index);

        public Duration TotalSlack
        {
            get => _proxyManager.ProxyObject(JavaObject.getTotalSlack());
            set => JavaObject.setTotalSlack(value?.JavaObject);
        }

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public bool UpdateNeeded
        {
            get => JavaObject.getUpdateNeeded();
            set => JavaObject.setUpdateNeeded(value);
        }

        public string WBS
        {
            get => JavaObject.getWBS();
            set => JavaObject.setWBS(value);
        }

        public Duration Work
        {
            get => _proxyManager.ProxyObject(JavaObject.getWork());
            set => JavaObject.setWork(value?.JavaObject);
        }

        public Duration WorkVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getWorkVariance());
            set => JavaObject.setWorkVariance(value?.JavaObject);
        }

        public Task ParentTask => _proxyManager.ProxyObject(JavaObject.getParentTask());

        public int? ParentTaskUniqueID => JavaObject.getParentTaskUniqueID().ConvertType();

        public IList<Task> ChildTasks => _proxyManager.ProxyList<org.mpxj.Task, Task>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildTasks());

        public bool Estimated
        {
            get => JavaObject.getEstimated();
            set => JavaObject.setEstimated(value);
        }

        public DateTime? Deadline
        {
            get => JavaObject.getDeadline().ConvertType();
            set => JavaObject.setDeadline(value.ConvertType());
        }

        public TaskType? Type
        {
            get => JavaObject.getType().ConvertType();
            set => JavaObject.setType(value.ConvertType());
        }

        public bool Null
        {
            get => JavaObject.getNull();
            set => JavaObject.setNull(value);
        }

        public bool ResumeValid
        {
            get => JavaObject.getResumeValid();
            set => JavaObject.setResumeValid(value);
        }

        public bool Recurring
        {
            get => JavaObject.getRecurring();
            set => JavaObject.setRecurring(value);
        }

        public bool OverAllocated
        {
            get => JavaObject.getOverAllocated();
            set => JavaObject.setOverAllocated(value);
        }

        public int? SubprojectTaskUniqueID
        {
            get => JavaObject.getSubprojectTaskUniqueID().ConvertType();
            set => JavaObject.setSubprojectTaskUniqueID(value.ConvertType());
        }

        public int? SubprojectTaskID
        {
            get => JavaObject.getSubprojectTaskID().ConvertType();
            set => JavaObject.setSubprojectTaskID(value.ConvertType());
        }

        public int? SubprojectTasksUniqueIDOffset
        {
            get => JavaObject.getSubprojectTasksUniqueIDOffset().ConvertType();
            set => JavaObject.setSubprojectTasksUniqueIDOffset(value.ConvertType());
        }

        public bool SubprojectReadOnly
        {
            get => JavaObject.getSubprojectReadOnly();
            set => JavaObject.setSubprojectReadOnly(value);
        }

        public bool ExternalTask
        {
            get => JavaObject.getExternalTask();
            set => JavaObject.setExternalTask(value);
        }

        public bool ExternalProject => JavaObject.getExternalProject();

        public double? ACWP
        {
            get => JavaObject.getACWP().ConvertType();
            set => JavaObject.setACWP(value.ConvertType());
        }

        public TimeUnit? LevelingDelayFormat
        {
            get => JavaObject.getLevelingDelayFormat().ConvertType();
            set => JavaObject.setLevelingDelayFormat(value.ConvertType());
        }

        public bool IgnoreResourceCalendar
        {
            get => JavaObject.getIgnoreResourceCalendar();
            set => JavaObject.setIgnoreResourceCalendar(value);
        }

        public double? PhysicalPercentComplete
        {
            get => JavaObject.getPhysicalPercentComplete().ConvertType();
            set => JavaObject.setPhysicalPercentComplete(value.ConvertType());
        }

        public EarnedValueMethod? EarnedValueMethod
        {
            get => JavaObject.getEarnedValueMethod().ConvertType();
            set => JavaObject.setEarnedValueMethod(value.ConvertType());
        }

        public Duration ActualWorkProtected
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualWorkProtected());
            set => JavaObject.setActualWorkProtected(value?.JavaObject);
        }

        public Duration ActualOvertimeWorkProtected
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualOvertimeWorkProtected());
            set => JavaObject.setActualOvertimeWorkProtected(value?.JavaObject);
        }

        public Duration RegularWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRegularWork());
            set => JavaObject.setRegularWork(value?.JavaObject);
        }

        public bool EffortDriven
        {
            get => JavaObject.getEffortDriven();
            set => JavaObject.setEffortDriven(value);
        }

        public DateTime? GetDate(int index) => JavaObject.getDate(index).ConvertType();

        public void SetDate(int index, DateTime value) => JavaObject.setDate(index, value.ConvertType());

        public double? OvertimeCost
        {
            get => JavaObject.getOvertimeCost().ConvertType();
            set => JavaObject.setOvertimeCost(value.ConvertType());
        }

        public double? ActualOvertimeCost
        {
            get => JavaObject.getActualOvertimeCost().ConvertType();
            set => JavaObject.setActualOvertimeCost(value.ConvertType());
        }

        public Duration ActualOvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualOvertimeWork());
            set => JavaObject.setActualOvertimeWork(value?.JavaObject);
        }

        public AccrueType? FixedCostAccrual
        {
            get => JavaObject.getFixedCostAccrual().ConvertType();
            set => JavaObject.setFixedCostAccrual(value.ConvertType());
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

        public bool LevelAssignments
        {
            get => JavaObject.getLevelAssignments();
            set => JavaObject.setLevelAssignments(value);
        }

        public bool LevelingCanSplit
        {
            get => JavaObject.getLevelingCanSplit();
            set => JavaObject.setLevelingCanSplit(value);
        }

        public Duration OvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getOvertimeWork());
            set => JavaObject.setOvertimeWork(value?.JavaObject);
        }

        public DateTime? PreleveledStart
        {
            get => JavaObject.getPreleveledStart().ConvertType();
            set => JavaObject.setPreleveledStart(value.ConvertType());
        }

        public DateTime? PreleveledFinish
        {
            get => JavaObject.getPreleveledFinish().ConvertType();
            set => JavaObject.setPreleveledFinish(value.ConvertType());
        }

        public Duration RemainingOvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingOvertimeWork());
            set => JavaObject.setRemainingOvertimeWork(value?.JavaObject);
        }

        public double? RemainingOvertimeCost
        {
            get => JavaObject.getRemainingOvertimeCost().ConvertType();
            set => JavaObject.setRemainingOvertimeCost(value.ConvertType());
        }

        public ProjectCalendar Calendar
        {
            get => _proxyManager.ProxyObject(JavaObject.getCalendar());
            set => JavaObject.setCalendar(value?.JavaObject);
        }

        public int? CalendarUniqueID
        {
            get => JavaObject.getCalendarUniqueID().ConvertType();
            set => JavaObject.setCalendarUniqueID(value.ConvertType());
        }

        public bool Expanded
        {
            get => JavaObject.getExpanded();
            set => JavaObject.setExpanded(value);
        }

        public Duration StartSlack
        {
            get => _proxyManager.ProxyObject(JavaObject.getStartSlack());
            set => JavaObject.setStartSlack(value?.JavaObject);
        }

        public Duration FinishSlack
        {
            get => _proxyManager.ProxyObject(JavaObject.getFinishSlack());
            set => JavaObject.setFinishSlack(value?.JavaObject);
        }

        public object GetFieldByAlias(string alias) => _proxyManager.GenericProxyObject(JavaObject.getFieldByAlias(alias));

        public void SetFieldByAlias(string alias, object value) => JavaObject.setFieldByAlias(alias, value.GenericJavaObject());

        public IList<DateTimeRange> Splits => _proxyManager.ProxyList<org.mpxj.LocalDateTimeRange, DateTimeRange>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getSplits());

        public void Remove() => JavaObject.remove();

        public ProjectFile ExpandSubproject() => _proxyManager.ProxyObject(JavaObject.expandSubproject());

        public ProjectFile SubprojectObject
        {
            get => _proxyManager.ProxyObject(JavaObject.getSubprojectObject());
            set => JavaObject.setSubprojectObject(value?.JavaObject);
        }

        public double? GetEnterpriseCost(int index) => JavaObject.getEnterpriseCost(index).ConvertType();

        public void SetEnterpriseCost(int index, double? value) => JavaObject.setEnterpriseCost(index, value.ConvertType());

        public DateTime? GetEnterpriseDate(int index) => JavaObject.getEnterpriseDate(index).ConvertType();

        public void SetEnterpriseDate(int index, DateTime value) => JavaObject.setEnterpriseDate(index, value.ConvertType());

        public Duration GetEnterpriseDuration(int index) => _proxyManager.ProxyObject(JavaObject.getEnterpriseDuration(index));

        public void SetEnterpriseDuration(int index, Duration value) => JavaObject.setEnterpriseDuration(index, value?.JavaObject);

        public bool GetEnterpriseFlag(int index) => JavaObject.getEnterpriseFlag(index);

        public void SetEnterpriseFlag(int index, bool value) => JavaObject.setEnterpriseFlag(index, value);

        public double? GetEnterpriseNumber(int index) => JavaObject.getEnterpriseNumber(index).ConvertType();

        public void SetEnterpriseNumber(int index, double? value) => JavaObject.setEnterpriseNumber(index, value.ConvertType());

        public string GetEnterpriseText(int index) => JavaObject.getEnterpriseText(index);

        public void SetEnterpriseText(int index, string value) => JavaObject.setEnterpriseText(index, value);

        public void SetBaselineCost(int baselineNumber, double? value) => JavaObject.setBaselineCost(baselineNumber, value.ConvertType());

        public void SetBaselineDuration(int baselineNumber, Duration value) => JavaObject.setBaselineDuration(baselineNumber, value?.JavaObject);

        public void SetBaselineFinish(int baselineNumber, DateTime value) => JavaObject.setBaselineFinish(baselineNumber, value.ConvertType());

        public void SetBaselineStart(int baselineNumber, DateTime value) => JavaObject.setBaselineStart(baselineNumber, value.ConvertType());

        public void SetBaselineWork(int baselineNumber, Duration value) => JavaObject.setBaselineWork(baselineNumber, value?.JavaObject);

        public double? GetBaselineCost(int baselineNumber) => JavaObject.getBaselineCost(baselineNumber).ConvertType();

        public Duration GetBaselineDuration(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineDuration(baselineNumber));

        public string GetBaselineDurationText(int baselineNumber) => JavaObject.getBaselineDurationText(baselineNumber);

        public void SetBaselineDurationText(int baselineNumber, string value) => JavaObject.setBaselineDurationText(baselineNumber, value);

        public DateTime? GetBaselineFinish(int baselineNumber) => JavaObject.getBaselineFinish(baselineNumber).ConvertType();

        public string GetBaselineFinishText(int baselineNumber) => JavaObject.getBaselineFinishText(baselineNumber);

        public void SetBaselineFinishText(int baselineNumber, string value) => JavaObject.setBaselineFinishText(baselineNumber, value);

        public DateTime? GetBaselineStart(int baselineNumber) => JavaObject.getBaselineStart(baselineNumber).ConvertType();

        public string GetBaselineStartText(int baselineNumber) => JavaObject.getBaselineStartText(baselineNumber);

        public void SetBaselineStartText(int baselineNumber, string value) => JavaObject.setBaselineStartText(baselineNumber, value);

        public Duration GetBaselineWork(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineWork(baselineNumber));

        public DateTime? CompleteThrough
        {
            get => JavaObject.getCompleteThrough().ConvertType();
            set => JavaObject.setCompleteThrough(value.ConvertType());
        }

        public DateTime? SummaryProgress
        {
            get => JavaObject.getSummaryProgress().ConvertType();
            set => JavaObject.setSummaryProgress(value.ConvertType());
        }

        public Guid? GUID
        {
            get => JavaObject.getGUID().ConvertType();
            set => JavaObject.setGUID(value.ConvertType());
        }

        public TaskMode? TaskMode
        {
            get => JavaObject.getTaskMode().ConvertType();
            set => JavaObject.setTaskMode(value.ConvertType());
        }

        public bool Active
        {
            get => JavaObject.getActive();
            set => JavaObject.setActive(value);
        }

        public Duration BaselineEstimatedDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineEstimatedDuration());
            set => JavaObject.setBaselineEstimatedDuration(value?.JavaObject);
        }

        public void SetBaselineEstimatedDuration(int baselineNumber, Duration value) => JavaObject.setBaselineEstimatedDuration(baselineNumber, value?.JavaObject);

        public Duration GetBaselineEstimatedDuration(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineEstimatedDuration(baselineNumber));

        public DateTime? BaselineEstimatedStart
        {
            get => JavaObject.getBaselineEstimatedStart().ConvertType();
            set => JavaObject.setBaselineEstimatedStart(value.ConvertType());
        }

        public DateTime? GetBaselineEstimatedStart(int baselineNumber) => JavaObject.getBaselineEstimatedStart(baselineNumber).ConvertType();

        public void SetBaselineEstimatedStart(int baselineNumber, DateTime value) => JavaObject.setBaselineEstimatedStart(baselineNumber, value.ConvertType());

        public DateTime? BaselineEstimatedFinish
        {
            get => JavaObject.getBaselineEstimatedFinish().ConvertType();
            set => JavaObject.setBaselineEstimatedFinish(value.ConvertType());
        }

        public DateTime? GetBaselineEstimatedFinish(int baselineNumber) => JavaObject.getBaselineEstimatedFinish(baselineNumber).ConvertType();

        public void SetBaselineEstimatedFinish(int baselineNumber, DateTime value) => JavaObject.setBaselineEstimatedFinish(baselineNumber, value.ConvertType());

        public double? BaselineFixedCost
        {
            get => JavaObject.getBaselineFixedCost().ConvertType();
            set => JavaObject.setBaselineFixedCost(value.ConvertType());
        }

        public void SetBaselineFixedCost(int baselineNumber, double? value) => JavaObject.setBaselineFixedCost(baselineNumber, value.ConvertType());

        public double? GetBaselineFixedCost(int baselineNumber) => JavaObject.getBaselineFixedCost(baselineNumber).ConvertType();

        public AccrueType? BaselineFixedCostAccrual
        {
            get => JavaObject.getBaselineFixedCostAccrual().ConvertType();
            set => JavaObject.setBaselineFixedCostAccrual(value.ConvertType());
        }

        public void SetBaselineFixedCostAccrual(int baselineNumber, AccrueType value) => JavaObject.setBaselineFixedCostAccrual(baselineNumber, value.ConvertType());

        public AccrueType? GetBaselineFixedCostAccrual(int baselineNumber) => JavaObject.getBaselineFixedCostAccrual(baselineNumber).ConvertType();

        public IList<ExpenseItem> ExpenseItems
        {
            get => _proxyManager.ProxyList<org.mpxj.ExpenseItem, ExpenseItem>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getExpenseItems());
            set => JavaObject.setExpenseItems(value.ConvertType());
        }

        public double? StoredMaterial
        {
            get => JavaObject.getStoredMaterial().ConvertType();
            set => JavaObject.setStoredMaterial(value.ConvertType());
        }

        public string FeatureOfWork
        {
            get => JavaObject.getFeatureOfWork();
            set => JavaObject.setFeatureOfWork(value);
        }

        public string CategoryOfWork
        {
            get => JavaObject.getCategoryOfWork();
            set => JavaObject.setCategoryOfWork(value);
        }

        public string PhaseOfWork
        {
            get => JavaObject.getPhaseOfWork();
            set => JavaObject.setPhaseOfWork(value);
        }

        public string BidItem
        {
            get => JavaObject.getBidItem();
            set => JavaObject.setBidItem(value);
        }

        public string ModOrClaimNumber
        {
            get => JavaObject.getModOrClaimNumber();
            set => JavaObject.setModOrClaimNumber(value);
        }

        public string WorkAreaCode
        {
            get => JavaObject.getWorkAreaCode();
            set => JavaObject.setWorkAreaCode(value);
        }

        public string ResponsibilityCode
        {
            get => JavaObject.getResponsibilityCode();
            set => JavaObject.setResponsibilityCode(value);
        }

        public int? WorkersPerDay
        {
            get => JavaObject.getWorkersPerDay().ConvertType();
            set => JavaObject.setWorkersPerDay(value.ConvertType());
        }

        public bool HammockCode
        {
            get => JavaObject.getHammockCode();
            set => JavaObject.setHammockCode(value);
        }
        
        public string Mail
        {
            get => JavaObject.getMail();
            set => JavaObject.setMail(value);
        }

        public string Section
        {
            get => JavaObject.getSection();
            set => JavaObject.setSection(value);
        }

        public string Manager
        {
            get => JavaObject.getManager();
            set => JavaObject.setManager(value);
        }

        public string Department
        {
            get => JavaObject.getDepartment();
            set => JavaObject.setDepartment(value);
        }

        public double? OverallPercentComplete
        {
            get => JavaObject.getOverallPercentComplete().ConvertType();
            set => JavaObject.setOverallPercentComplete(value.ConvertType());
        }

        public DateTime? PlannedFinish
        {
            get => JavaObject.getPlannedFinish().ConvertType();
            set => JavaObject.setPlannedFinish(value.ConvertType());
        }

        public DateTime? PlannedStart
        {
            get => JavaObject.getPlannedStart().ConvertType();
            set => JavaObject.setPlannedStart(value.ConvertType());
        }

        public Duration PlannedDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getPlannedDuration());
            set => JavaObject.setPlannedDuration(value?.JavaObject);
        }

        public Duration PlannedWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getPlannedWork());
            set => JavaObject.setPlannedWork(value?.JavaObject);
        }

        public double? PlannedCost
        {
            get => JavaObject.getPlannedCost().ConvertType();
            set => JavaObject.setPlannedCost(value.ConvertType());
        }

        public DateTime? SuspendDate
        {
            get => JavaObject.getSuspendDate().ConvertType();
            set => JavaObject.setSuspendDate(value.ConvertType());
        }
        
        public int? PrimaryResourceUniqueID
        {
            get => JavaObject.getPrimaryResourceUniqueID().ConvertType();
            set => JavaObject.setPrimaryResourceUniqueID(value.ConvertType());
        }

        public Resource PrimaryResource
        {
            get => _proxyManager.ProxyObject(JavaObject.getPrimaryResource());
            set => JavaObject.setPrimaryResource(value.JavaObject);
        }

        public string CanonicalActivityID => JavaObject.getCanonicalActivityID();

        public string ActivityID
        {
            get => JavaObject.getActivityID();
            set => JavaObject.setActivityID(value);
        }

        public PercentCompleteType? PercentCompleteType
        {
            get => JavaObject.getPercentCompleteType().ConvertType();
            set => JavaObject.setPercentCompleteType(value.ConvertType());
        }

        public ActivityStatus? ActivityStatus
        {
            get => JavaObject.getActivityStatus().ConvertType();
            set => JavaObject.setActivityStatus(value.ConvertType());
        }

        public ActivityType? ActivityType
        {
            get => JavaObject.getActivityType().ConvertType();
            set => JavaObject.setActivityType(value.ConvertType());
        }

        public bool LongestPath
        {
            get => JavaObject.getLongestPath();
            set => JavaObject.setLongestPath(value);
        }

        public DateTime? ExternalEarlyStart
        {
            get => JavaObject.getExternalEarlyStart().ConvertType();
            set => JavaObject.setExternalEarlyStart(value.ConvertType());
        }

        public DateTime? ExternalLateFinish
        {
            get => JavaObject.getExternalLateFinish().ConvertType();
            set => JavaObject.setExternalLateFinish(value.ConvertType());
        }

        public int? SprintID
        {
            get => JavaObject.getSprintID().ConvertType();
            set => JavaObject.setSprintID(value.ConvertType());
        }

        public int? BoardStatusID
        {
            get => JavaObject.getBoardStatusID().ConvertType();
            set => JavaObject.setBoardStatusID(value.ConvertType());
        }

        public bool ResponsePending
        {
            get => JavaObject.getResponsePending();
            set => JavaObject.setResponsePending(value);
        }

        public DateTime? ScheduledStart
        {
            get => JavaObject.getScheduledStart().ConvertType();
            set => JavaObject.setScheduledStart(value.ConvertType());
        }

        public DateTime? ScheduledFinish
        {
            get => JavaObject.getScheduledFinish().ConvertType();
            set => JavaObject.setScheduledFinish(value.ConvertType());
        }

        public Duration ScheduledDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getScheduledDuration());
            set => JavaObject.setScheduledDuration(value?.JavaObject);
        }

        public double? BudgetCost
        {
            get => JavaObject.getBudgetCost().ConvertType();
            set => JavaObject.setBudgetCost(value.ConvertType());
        }

        public Duration BudgetWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBudgetWork());
            set => JavaObject.setBudgetWork(value?.JavaObject);
        }

        public double? BaselineBudgetCost
        {
            get => JavaObject.getBaselineBudgetCost().ConvertType();
            set => JavaObject.setBaselineBudgetCost(value.ConvertType());
        }

        public Duration BaselineBudgetWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineBudgetWork());
            set => JavaObject.setBaselineBudgetWork(value?.JavaObject);
        }

        public double? GetBaselineBudgetCost(int baselineNumber) => JavaObject.getBaselineBudgetCost(baselineNumber).ConvertType();

        public void SetBaselineBudgetCost(int baselineNumber, double? value) => JavaObject.setBaselineBudgetCost(baselineNumber, value.ConvertType());

        public Duration GetBaselineBudgetWork(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineBudgetWork(baselineNumber));

        public void SetBaselineBudgetWork(int baselineNumber, Duration value) => JavaObject.setBaselineBudgetWork(baselineNumber, value?.JavaObject);

        public int? SequenceNumber
        {
            get => JavaObject.getSequenceNumber().ConvertType();
            set => JavaObject.setSequenceNumber(value.ConvertType());
        }

        public IList<Step> Steps
        {
            get => _proxyManager.ProxyList<org.mpxj.Step, Step>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getSteps());
            set => JavaObject.setSteps(value.ConvertType());
        }

        public int? LocationUniqueID
        {
            get => JavaObject.getLocationUniqueID().ConvertType();
            set => JavaObject.setLocationUniqueID(value.ConvertType());
        }

        public Location Location
        {
            get => _proxyManager.ProxyObject(JavaObject.getLocation());
            set => JavaObject.setLocation(value?.JavaObject);
        }

        public string BarName
        {
            get => JavaObject.getBarName();
            set => JavaObject.setBarName(value);
        }

        public DateTime? ExpectedFinish
        {
            get => JavaObject.getExpectedFinish().ConvertType();
            set => JavaObject.setExpectedFinish(value.ConvertType());
        }

        public Duration ActualWorkLabor
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualWorkLabor());
            set => JavaObject.setActualWorkLabor(value?.JavaObject);
        }

        public Duration ActualWorkNonlabor
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualWorkNonlabor());
            set => JavaObject.setActualWorkNonlabor(value?.JavaObject);
        }

        public Duration PlannedWorkLabor
        {
            get => _proxyManager.ProxyObject(JavaObject.getPlannedWorkLabor());
            set => JavaObject.setPlannedWorkLabor(value?.JavaObject);
        }

        public Duration PlannedWorkNonlabor
        {
            get => _proxyManager.ProxyObject(JavaObject.getPlannedWorkNonlabor());
            set => JavaObject.setPlannedWorkNonlabor(value?.JavaObject);
        }

        public Duration RemainingWorkLabor
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingWorkLabor());
            set => JavaObject.setRemainingWorkLabor(value?.JavaObject);
        }

        public Duration RemainingWorkNonLabor
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingWorkNonlabor());
            set => JavaObject.setRemainingWorkNonlabor(value?.JavaObject);
        }

        public int? FloatPath
        {
            get => JavaObject.getFloatPath().ConvertType();
            set => JavaObject.setFloatPath(value.ConvertType());
        }

        public int? FloatPathOrder
        {
            get => JavaObject.getFloatPathOrder().ConvertType();
            set => JavaObject.setFloatPathOrder(value.ConvertType());
        }

        public bool ShowStartText => JavaObject.getShowStartText();

        public bool ShowFinishText => JavaObject.getShowFinishText();

        public bool ShowDurationText => JavaObject.getShowDurationText();

        public double? ActivityPercentComplete => JavaObject.getActivityPercentComplete().ConvertType();
        
        public Task BaselineTask => _proxyManager.ProxyObject(JavaObject.getBaselineTask());

        public Task GetBaselineTask(int index) => _proxyManager.ProxyObject(JavaObject.getBaselineTask(index));

        public ProjectCalendar EffectiveCalendar => _proxyManager.ProxyObject(JavaObject.getEffectiveCalendar());

        public override string ToString() => JavaObject.toString();

        public bool IsPredecessor(Task task) => JavaObject.isPredecessor(task.JavaObject);

        public bool IsSuccessor(Task task) => JavaObject.isSuccessor(task.JavaObject);

        public bool HasChildTasks => JavaObject.hasChildTasks();
    }
}
