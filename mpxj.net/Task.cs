using org.mpxj.proxy;
using System;
using System.Collections.Generic;

namespace org.mpxj
{
    public class Task : AbstractFieldContainer, IProjectEntityWithID, IChildTaskContainer, IJavaObjectProxy<net.sf.mpxj.Task>
    {
        public new net.sf.mpxj.Task JavaObject => (net.sf.mpxj.Task)base.JavaObject;

        internal Task(ProxyManager proxyManager, net.sf.mpxj.Task javaObject) : base(proxyManager, javaObject) { }

        public RecurringTask AddRecurringTask() => _proxyManager.ProxyObject(JavaObject.addRecurringTask());

        public RecurringTask RecurringTask => _proxyManager.ProxyObject(JavaObject.getRecurringTask());

        public IList<ActivityCodeValue> ActivityCodes => _proxyManager.ProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getActivityCodes());

        public void AddActivityCode(ActivityCodeValue value) => JavaObject.addActivityCode(value.JavaObject);

        public ResourceAssignment AddResourceAssignment(Resource resource) => _proxyManager.ProxyObject(JavaObject.addResourceAssignment(resource.JavaObject));

        public void AddResourceAssignment(ResourceAssignment assignment) => JavaObject.addResourceAssignment(assignment.JavaObject);

        public ResourceAssignment GetExistingResourceAssignment(Resource resource) => _proxyManager.ProxyObject(JavaObject.getExistingResourceAssignment(resource.JavaObject));

        public IList<ResourceAssignment> ResourceAssignments => _proxyManager.ProxyList<net.sf.mpxj.ResourceAssignment, ResourceAssignment>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getResourceAssignments());

        public Relation AddPredecessor(Task targetTask, RelationType type, Duration lag) => _proxyManager.ProxyObject(JavaObject.addPredecessor(targetTask.JavaObject, type.ConvertType(), lag.JavaObject));

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
            set => JavaObject.setActualDuration(value.JavaObject);
        }

        public java.time.LocalDateTime ActualFinish
        {
            get => JavaObject.getActualFinish();
            set => JavaObject.setActualFinish(value);
        }

        public java.time.LocalDateTime ActualStart
        {
            get => JavaObject.getActualStart();
            set => JavaObject.setActualStart(value);
        }

        public Duration ActualWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualWork());
            set => JavaObject.setActualWork(value.JavaObject);
        }

        public double? BaselineCost
        {
            get => JavaObject.getBaselineCost().ConvertType();
            set => JavaObject.setBaselineCost(value.ConvertType());
        }

        public Duration BaselineDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineDuration());
            set => JavaObject.setBaselineDuration(value.JavaObject);
        }

        public string BaselineDurationText
        {
            get => JavaObject.getBaselineDurationText();
            set => JavaObject.setBaselineDurationText(value);
        }

        public java.time.LocalDateTime BaselineFinish
        {
            get => JavaObject.getBaselineFinish();
            set => JavaObject.setBaselineFinish(value);
        }

        public string BaselineFinishText
        {
            get => JavaObject.getBaselineFinishText();
            set => JavaObject.setBaselineFinishText(value);
        }

        public java.time.LocalDateTime BaselineStart
        {
            get => JavaObject.getBaselineStart();
            set => JavaObject.setBaselineStart(value);
        }

        public string BaselineStartText
        {
            get => JavaObject.getBaselineStartText();
            set => JavaObject.setBaselineStartText(value);
        }

        public Duration BaselineWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineWork());
            set => JavaObject.setBaselineWork(value.JavaObject);
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

        public java.time.LocalDateTime ConstraintDate
        {
            get => JavaObject.getConstraintDate();
            set => JavaObject.setConstraintDate(value);
        }

        public java.time.LocalDateTime SecondaryConstraintDate
        {
            get => JavaObject.getSecondaryConstraintDate();
            set => JavaObject.setSecondaryConstraintDate(value);
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

        public java.time.LocalDateTime CreateDate
        {
            get => JavaObject.getCreateDate();
            set => JavaObject.setCreateDate(value);
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
            get => _proxyManager.ProxyObject(JavaObject.getLevelingDelay());
            set => JavaObject.setLevelingDelay(value.JavaObject);
        }

        public Duration Duration
        {
            get => _proxyManager.ProxyObject(JavaObject.getDuration());
            set => JavaObject.setDuration(value.JavaObject);
        }

        public string DurationText
        {
            get => JavaObject.getDurationText();
            set => JavaObject.setDurationText(value);
        }

        public void SetDuration(int index, Duration value) => JavaObject.setDuration(index, value.JavaObject);

        public Duration GetDuration(int index) => _proxyManager.ProxyObject(JavaObject.getDuration(index));

        public Duration DurationVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getDurationVariance());
            set => JavaObject.setDurationVariance(value.JavaObject);
        }

        public java.time.LocalDateTime EarlyFinish
        {
            get => JavaObject.getEarlyFinish();
            set => JavaObject.setEarlyFinish(value);
        }

        public java.time.LocalDateTime RemainingEarlyFinish
        {
            get => JavaObject.getRemainingEarlyFinish();
            set => JavaObject.setRemainingEarlyFinish(value);
        }

        public java.time.LocalDateTime EarlyStart
        {
            get => JavaObject.getEarlyStart();
            set => JavaObject.setEarlyStart(value);
        }

        public java.time.LocalDateTime RemainingEarlyStart
        {
            get => JavaObject.getRemainingEarlyStart();
            set => JavaObject.setRemainingEarlyStart(value);
        }

        public java.time.LocalDateTime Finish
        {
            get => JavaObject.getFinish();
            set => JavaObject.setFinish(value);
        }

        public string FinishText
        {
            get => JavaObject.getFinishText();
            set => JavaObject.setFinishText(value);
        }

        public void SetFinish(int index, java.time.LocalDateTime value) => JavaObject.setFinish(index, value);

        public java.time.LocalDateTime GetFinish(int index) => JavaObject.getFinish(index);

        public Duration FinishVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getFinishVariance());
            set => JavaObject.setFinishVariance(value.JavaObject);
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
            set => JavaObject.setFreeSlack(value.JavaObject);
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

        public java.time.LocalDateTime LateFinish
        {
            get => JavaObject.getLateFinish();
            set => JavaObject.setLateFinish(value);
        }

        public java.time.LocalDateTime RemainingLateFinish
        {
            get => JavaObject.getRemainingLateFinish();
            set => JavaObject.setRemainingLateFinish(value);
        }

        public java.time.LocalDateTime LateStart
        {
            get => JavaObject.getLateStart();
            set => JavaObject.setLateStart(value);
        }

        public java.time.LocalDateTime RemainingLateStart
        {
            get => JavaObject.getRemainingLateStart();
            set => JavaObject.setRemainingLateStart(value);
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
            set => JavaObject.setNotesObject(value.JavaObject);
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

        public IList<Relation> Predecessors => _proxyManager.ProxyList<net.sf.mpxj.Relation, Relation>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getPredecessors());

        public IList<Relation> Successors => _proxyManager.ProxyList<net.sf.mpxj.Relation, Relation>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getSuccessors());

        public Priority Priority
        {
            get => _proxyManager.ProxyObject(JavaObject.getPriority());
            set => JavaObject.setPriority(value.JavaObject);
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
            set => JavaObject.setRemainingDuration(value.JavaObject);
        }

        public Duration RemainingWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingWork());
            set => JavaObject.setRemainingWork(value.JavaObject);
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

        public java.time.LocalDateTime Resume
        {
            get => JavaObject.getResume();
            set => JavaObject.setResume(value);
        }

        public bool Rollup
        {
            get => JavaObject.getRollup();
            set => JavaObject.setRollup(value);
        }

        public java.time.LocalDateTime Start
        {
            get => JavaObject.getStart();
            set => JavaObject.setStart(value);
        }

        public string StartText
        {
            get => JavaObject.getStartText();
            set => JavaObject.setStartText(value);
        }

        public void SetStart(int index, java.time.LocalDateTime value) => JavaObject.setStart(index, value);

        public java.time.LocalDateTime GetStart(int index) => JavaObject.getStart(index);

        public Duration StartVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getStartVariance());
            set => JavaObject.setStartVariance(value.JavaObject);
        }

        public java.time.LocalDateTime Stop
        {
            get => JavaObject.getStop();
            set => JavaObject.setStop(value);
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
            set => JavaObject.setTotalSlack(value.JavaObject);
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
            set => JavaObject.setWork(value.JavaObject);
        }

        public Duration WorkVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getWorkVariance());
            set => JavaObject.setWorkVariance(value.JavaObject);
        }

        public Task ParentTask => _proxyManager.ProxyObject(JavaObject.getParentTask());

        public int? ParentTaskUniqueID => JavaObject.getParentTaskUniqueID().ConvertType();

        public IList<Task> ChildTasks => _proxyManager.ProxyList<net.sf.mpxj.Task, Task>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildTasks());

        public bool Estimated
        {
            get => JavaObject.getEstimated();
            set => JavaObject.setEstimated(value);
        }

        public java.time.LocalDateTime Deadline
        {
            get => JavaObject.getDeadline();
            set => JavaObject.setDeadline(value);
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
            set => JavaObject.setActualWorkProtected(value.JavaObject);
        }

        public Duration ActualOvertimeWorkProtected
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualOvertimeWorkProtected());
            set => JavaObject.setActualOvertimeWorkProtected(value.JavaObject);
        }

        public Duration RegularWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRegularWork());
            set => JavaObject.setRegularWork(value.JavaObject);
        }

        public bool EffortDriven
        {
            get => JavaObject.getEffortDriven();
            set => JavaObject.setEffortDriven(value);
        }

        public java.time.LocalDateTime GetDate(int index) => JavaObject.getDate(index);

        public void SetDate(int index, java.time.LocalDateTime value) => JavaObject.setDate(index, value);

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
            set => JavaObject.setActualOvertimeWork(value.JavaObject);
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
            set => JavaObject.setOvertimeWork(value.JavaObject);
        }

        public java.time.LocalDateTime PreleveledStart
        {
            get => JavaObject.getPreleveledStart();
            set => JavaObject.setPreleveledStart(value);
        }

        public java.time.LocalDateTime PreleveledFinish
        {
            get => JavaObject.getPreleveledFinish();
            set => JavaObject.setPreleveledFinish(value);
        }

        public Duration RemainingOvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingOvertimeWork());
            set => JavaObject.setRemainingOvertimeWork(value.JavaObject);
        }

        public double? RemainingOvertimeCost
        {
            get => JavaObject.getRemainingOvertimeCost().ConvertType();
            set => JavaObject.setRemainingOvertimeCost(value.ConvertType());
        }

        public ProjectCalendar Calendar
        {
            get => _proxyManager.ProxyObject(JavaObject.getCalendar());
            set => JavaObject.setCalendar(value.JavaObject);
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
            set => JavaObject.setStartSlack(value.JavaObject);
        }

        public Duration FinishSlack
        {
            get => _proxyManager.ProxyObject(JavaObject.getFinishSlack());
            set => JavaObject.setFinishSlack(value.JavaObject);
        }

        public object GetFieldByAlias(string alias) => _proxyManager.GenericProxyObject(JavaObject.getFieldByAlias(alias));

        public void SetFieldByAlias(string alias, object value) => JavaObject.setFieldByAlias(alias, value.GenericJavaObject());

        public IList<LocalDateTimeRange> Splits
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.LocalDateTimeRange, LocalDateTimeRange>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getSplits());
            // TODO: handle list argument
            //set => JavaObject.setSplits(value);
        }

        public void Remove() => JavaObject.remove();

        public ProjectFile ExpandSubproject() => _proxyManager.ProxyObject(JavaObject.expandSubproject());

        public ProjectFile SubprojectObject
        {
            get => _proxyManager.ProxyObject(JavaObject.getSubprojectObject());
            set => JavaObject.setSubprojectObject(value.JavaObject);
        }

        public double? GetEnterpriseCost(int index) => JavaObject.getEnterpriseCost(index).ConvertType();

        public void SetEnterpriseCost(int index, double? value) => JavaObject.setEnterpriseCost(index, value.ConvertType());

        public java.time.LocalDateTime GetEnterpriseDate(int index) => JavaObject.getEnterpriseDate(index);

        public void SetEnterpriseDate(int index, java.time.LocalDateTime value) => JavaObject.setEnterpriseDate(index, value);

        public Duration GetEnterpriseDuration(int index) => _proxyManager.ProxyObject(JavaObject.getEnterpriseDuration(index));

        public void SetEnterpriseDuration(int index, Duration value) => JavaObject.setEnterpriseDuration(index, value.JavaObject);

        public bool GetEnterpriseFlag(int index) => JavaObject.getEnterpriseFlag(index);

        public void SetEnterpriseFlag(int index, bool value) => JavaObject.setEnterpriseFlag(index, value);

        public double? GetEnterpriseNumber(int index) => JavaObject.getEnterpriseNumber(index).ConvertType();

        public void SetEnterpriseNumber(int index, double? value) => JavaObject.setEnterpriseNumber(index, value.ConvertType());

        public string GetEnterpriseText(int index) => JavaObject.getEnterpriseText(index);

        public void SetEnterpriseText(int index, string value) => JavaObject.setEnterpriseText(index, value);

        public void SetBaselineCost(int baselineNumber, double? value) => JavaObject.setBaselineCost(baselineNumber, value.ConvertType());

        public void SetBaselineDuration(int baselineNumber, Duration value) => JavaObject.setBaselineDuration(baselineNumber, value.JavaObject);

        public void SetBaselineFinish(int baselineNumber, java.time.LocalDateTime value) => JavaObject.setBaselineFinish(baselineNumber, value);

        public void SetBaselineStart(int baselineNumber, java.time.LocalDateTime value) => JavaObject.setBaselineStart(baselineNumber, value);

        public void SetBaselineWork(int baselineNumber, Duration value) => JavaObject.setBaselineWork(baselineNumber, value.JavaObject);

        public double? GetBaselineCost(int baselineNumber) => JavaObject.getBaselineCost(baselineNumber).ConvertType();

        public Duration GetBaselineDuration(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineDuration(baselineNumber));

        public string GetBaselineDurationText(int baselineNumber) => JavaObject.getBaselineDurationText(baselineNumber);

        public void SetBaselineDurationText(int baselineNumber, string value) => JavaObject.setBaselineDurationText(baselineNumber, value);

        public java.time.LocalDateTime GetBaselineFinish(int baselineNumber) => JavaObject.getBaselineFinish(baselineNumber);

        public string GetBaselineFinishText(int baselineNumber) => JavaObject.getBaselineFinishText(baselineNumber);

        public void SetBaselineFinishText(int baselineNumber, string value) => JavaObject.setBaselineFinishText(baselineNumber, value);

        public java.time.LocalDateTime GetBaselineStart(int baselineNumber) => JavaObject.getBaselineStart(baselineNumber);

        public string GetBaselineStartText(int baselineNumber) => JavaObject.getBaselineStartText(baselineNumber);

        public void SetBaselineStartText(int baselineNumber, string value) => JavaObject.setBaselineStartText(baselineNumber, value);

        public Duration GetBaselineWork(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineWork(baselineNumber));

        public java.time.LocalDateTime CompleteThrough
        {
            get => JavaObject.getCompleteThrough();
            set => JavaObject.setCompleteThrough(value);
        }

        public java.time.LocalDateTime SummaryProgress
        {
            get => JavaObject.getSummaryProgress();
            set => JavaObject.setSummaryProgress(value);
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
            set => JavaObject.setBaselineEstimatedDuration(value.JavaObject);
        }

        public void SetBaselineEstimatedDuration(int baselineNumber, Duration value) => JavaObject.setBaselineEstimatedDuration(baselineNumber, value.JavaObject);

        public Duration GetBaselineEstimatedDuration(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineEstimatedDuration(baselineNumber));

        public java.time.LocalDateTime BaselineEstimatedStart
        {
            get => JavaObject.getBaselineEstimatedStart();
            set => JavaObject.setBaselineEstimatedStart(value);
        }

        public java.time.LocalDateTime GetBaselineEstimatedStart(int baselineNumber) => JavaObject.getBaselineEstimatedStart(baselineNumber);

        public void SetBaselineEstimatedStart(int baselineNumber, java.time.LocalDateTime value) => JavaObject.setBaselineEstimatedStart(baselineNumber, value);

        public java.time.LocalDateTime BaselineEstimatedFinish
        {
            get => JavaObject.getBaselineEstimatedFinish();
            set => JavaObject.setBaselineEstimatedFinish(value);
        }

        public java.time.LocalDateTime GetBaselineEstimatedFinish(int baselineNumber) => JavaObject.getBaselineEstimatedFinish(baselineNumber);

        public void SetBaselineEstimatedFinish(int baselineNumber, java.time.LocalDateTime value) => JavaObject.setBaselineEstimatedFinish(baselineNumber, value);

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
            get => _proxyManager.ProxyList<net.sf.mpxj.ExpenseItem, ExpenseItem>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getExpenseItems());
            // TODO: handle list argument
            //set => JavaObject.setExpenseItems(value);
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

        public java.time.LocalDateTime PlannedFinish
        {
            get => JavaObject.getPlannedFinish();
            set => JavaObject.setPlannedFinish(value);
        }

        public java.time.LocalDateTime PlannedStart
        {
            get => JavaObject.getPlannedStart();
            set => JavaObject.setPlannedStart(value);
        }

        public Duration PlannedDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getPlannedDuration());
            set => JavaObject.setPlannedDuration(value.JavaObject);
        }

        public Duration PlannedWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getPlannedWork());
            set => JavaObject.setPlannedWork(value.JavaObject);
        }

        public double? PlannedCost
        {
            get => JavaObject.getPlannedCost().ConvertType();
            set => JavaObject.setPlannedCost(value.ConvertType());
        }

        public java.time.LocalDateTime SuspendDate
        {
            get => JavaObject.getSuspendDate();
            set => JavaObject.setSuspendDate(value);
        }

        public int? PrimaryResourceID
        {
            get => JavaObject.getPrimaryResourceID().ConvertType();
            set => JavaObject.setPrimaryResourceID(value.ConvertType());
        }

        public string CanonicalActivityID
        {
            get => JavaObject.getCanonicalActivityID();
        }

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

        public java.time.LocalDateTime ExternalEarlyStart
        {
            get => JavaObject.getExternalEarlyStart();
            set => JavaObject.setExternalEarlyStart(value);
        }

        public java.time.LocalDateTime ExternalLateFinish
        {
            get => JavaObject.getExternalLateFinish();
            set => JavaObject.setExternalLateFinish(value);
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

        public java.time.LocalDateTime ScheduledStart
        {
            get => JavaObject.getScheduledStart();
            set => JavaObject.setScheduledStart(value);
        }

        public java.time.LocalDateTime ScheduledFinish
        {
            get => JavaObject.getScheduledFinish();
            set => JavaObject.setScheduledFinish(value);
        }

        public Duration ScheduledDuration
        {
            get => _proxyManager.ProxyObject(JavaObject.getScheduledDuration());
            set => JavaObject.setScheduledDuration(value.JavaObject);
        }

        public double? BudgetCost
        {
            get => JavaObject.getBudgetCost().ConvertType();
            set => JavaObject.setBudgetCost(value.ConvertType());
        }

        public Duration BudgetWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBudgetWork());
            set => JavaObject.setBudgetWork(value.JavaObject);
        }

        public double? BaselineBudgetCost
        {
            get => JavaObject.getBaselineBudgetCost().ConvertType();
            set => JavaObject.setBaselineBudgetCost(value.ConvertType());
        }

        public Duration BaselineBudgetWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineBudgetWork());
            set => JavaObject.setBaselineBudgetWork(value.JavaObject);
        }

        public double? GetBaselineBudgetCost(int baselineNumber) => JavaObject.getBaselineBudgetCost(baselineNumber).ConvertType();

        public void SetBaselineBudgetCost(int baselineNumber, double? value) => JavaObject.setBaselineBudgetCost(baselineNumber, value.ConvertType());

        public Duration GetBaselineBudgetWork(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineBudgetWork(baselineNumber));

        public void SetBaselineBudgetWork(int baselineNumber, Duration value) => JavaObject.setBaselineBudgetWork(baselineNumber, value.JavaObject);

        public int? SequenceNumber
        {
            get => JavaObject.getSequenceNumber().ConvertType();
            set => JavaObject.setSequenceNumber(value.ConvertType());
        }

        public IList<Step> Steps
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.Step, Step>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getSteps());
            // TODO: handle list argument
            //set => JavaObject.setSteps(value);
        }

        public int? LocationUniqueID
        {
            get => JavaObject.getLocationUniqueID().ConvertType();
            set => JavaObject.setLocationUniqueID(value.ConvertType());
        }

        public Location Location
        {
            get => _proxyManager.ProxyObject(JavaObject.getLocation());
            set => JavaObject.setLocation(value.JavaObject);
        }

        public string BarName
        {
            get => JavaObject.getBarName();
            set => JavaObject.setBarName(value);
        }

        public java.time.LocalDateTime ExpectedFinish
        {
            get => JavaObject.getExpectedFinish();
            set => JavaObject.setExpectedFinish(value);
        }

        public ProjectCalendar EffectiveCalendar => _proxyManager.ProxyObject(JavaObject.getEffectiveCalendar());

        public override string ToString() => JavaObject.toString();

        public bool IsPredecessor(Task task) => JavaObject.isPredecessor(task.JavaObject);

        public bool IsSucessor(Task task) => JavaObject.isSucessor(task.JavaObject);

        public bool HasChildTasks => JavaObject.hasChildTasks();
    }
}
