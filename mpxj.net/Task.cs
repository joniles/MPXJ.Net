﻿using System.Collections.Generic;

namespace org.mpxj
{
    public class Task : AbstractFieldContainer, IProjectEntityWithID, IChildTaskContainer, IJavaObjectProxy<net.sf.mpxj.Task>
    {
        public new net.sf.mpxj.Task JavaObject { get => (net.sf.mpxj.Task)base.JavaObject; }

        internal Task(ProjectFile projectFile, net.sf.mpxj.Task javaObject) : base(projectFile, javaObject) { }


        public java.util.UUID SubprojectGUID
        {
            get => JavaObject.getSubprojectGUID();
            set => JavaObject.setSubprojectGUID(value);
        }

        public java.lang.Number PercentageComplete
        {
            get => JavaObject.getPercentageComplete();
            set => JavaObject.setPercentageComplete(value);
        }

        public java.lang.Number PercentageWorkComplete
        {
            get => JavaObject.getPercentageWorkComplete();
            set => JavaObject.setPercentageWorkComplete(value);
        }

        public java.lang.Number ActualCost
        {
            get => JavaObject.getActualCost();
            set => JavaObject.setActualCost(value);
        }

        public net.sf.mpxj.Duration ActualDuration
        {
            get => JavaObject.getActualDuration();
            set => JavaObject.setActualDuration(value);
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

        public net.sf.mpxj.Duration ActualWork
        {
            get => JavaObject.getActualWork();
            set => JavaObject.setActualWork(value);
        }

        public java.lang.Number BaselineCost
        {
            get => JavaObject.getBaselineCost();
            set => JavaObject.setBaselineCost(value);
        }

        public net.sf.mpxj.Duration BaselineDuration
        {
            get => JavaObject.getBaselineDuration();
            set => JavaObject.setBaselineDuration(value);
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

        public net.sf.mpxj.Duration BaselineWork
        {
            get => JavaObject.getBaselineWork();
            set => JavaObject.setBaselineWork(value);
        }

        public java.lang.Number BCWP
        {
            get => JavaObject.getBCWP();
            set => JavaObject.setBCWP(value);
        }

        public java.lang.Number BCWS
        {
            get => JavaObject.getBCWS();
            set => JavaObject.setBCWS(value);
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

        public net.sf.mpxj.ConstraintType ConstraintType
        {
            get => JavaObject.getConstraintType();
            set => JavaObject.setConstraintType(value);
        }

        public net.sf.mpxj.ConstraintType SecondaryConstraintType
        {
            get => JavaObject.getSecondaryConstraintType();
            set => JavaObject.setSecondaryConstraintType(value);
        }

        public string Contact
        {
            get => JavaObject.getContact();
            set => JavaObject.setContact(value);
        }

        public java.lang.Number Cost
        {
            get => JavaObject.getCost();
            set => JavaObject.setCost(value);
        }

        public java.lang.Number CostVariance
        {
            get => JavaObject.getCostVariance();
            set => JavaObject.setCostVariance(value);
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

        public java.lang.Number CV
        {
            get => JavaObject.getCV();
            set => JavaObject.setCV(value);
        }

        public net.sf.mpxj.Duration LevelingDelay
        {
            get => JavaObject.getLevelingDelay();
            set => JavaObject.setLevelingDelay(value);
        }

        public net.sf.mpxj.Duration Duration
        {
            get => JavaObject.getDuration();
            set => JavaObject.setDuration(value);
        }

        public string DurationText
        {
            get => JavaObject.getDurationText();
            set => JavaObject.setDurationText(value);
        }

        public void SetDuration(int index, net.sf.mpxj.Duration value)
        {
            JavaObject.setDuration(index, value);
        }

        public net.sf.mpxj.Duration GetDuration(int index)
        {
            return JavaObject.getDuration(index);
        }

        public net.sf.mpxj.Duration DurationVariance
        {
            get => JavaObject.getDurationVariance();
            set => JavaObject.setDurationVariance(value);
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

        public void SetFinish(int index, java.time.LocalDateTime value)
        {
            JavaObject.setFinish(index, value);
        }

        public java.time.LocalDateTime GetFinish(int index)
        {
            return JavaObject.getFinish(index);
        }

        public net.sf.mpxj.Duration FinishVariance
        {
            get => JavaObject.getFinishVariance();
            set => JavaObject.setFinishVariance(value);
        }

        public java.lang.Number FixedCost
        {
            get => JavaObject.getFixedCost();
            set => JavaObject.setFixedCost(value);
        }

        public void SetFlag(int index, bool value)
        {
            JavaObject.setFlag(index, value);
        }

        public bool GetFlag(int index)
        {
            return JavaObject.getFlag(index);
        }

        public net.sf.mpxj.Duration FreeSlack
        {
            get => JavaObject.getFreeSlack();
            set => JavaObject.setFreeSlack(value);
        }

        public bool HideBar
        {
            get => JavaObject.getHideBar();
            set => JavaObject.setHideBar(value);
        }

        public java.lang.Integer ID
        {
            get => JavaObject.getID();
            set => JavaObject.setID(value);
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

        public net.sf.mpxj.Notes NotesObject
        {
            get => JavaObject.getNotesObject();
            set => JavaObject.setNotesObject(value);
        }

        public Task AddTask()
        {            
            return Parent.ProxyObject(JavaObject.addTask());
        }

        public void SetNumber(int index, java.lang.Number value)
        {
            JavaObject.setNumber(index, value);
        }

        public java.lang.Number GetNumber(int index)
        {
            return JavaObject.getNumber(index);
        }

        public java.lang.Integer Objects
        {
            get => JavaObject.getObjects();
            set => JavaObject.setObjects(value);
        }

        public java.lang.Integer OutlineLevel
        {
            get => JavaObject.getOutlineLevel();
            set => JavaObject.setOutlineLevel(value);
        }

        public string OutlineNumber
        {
            get => JavaObject.getOutlineNumber();
            set => JavaObject.setOutlineNumber(value);
        }

        public IList<Task> Predecessors
        {
            get => Parent.ProxyTaskList(JavaObject.getPredecessors());
        }

        public IList<Task> Successors
        {
            get => Parent.ProxyTaskList(JavaObject.getSuccessors());
        }

        public net.sf.mpxj.Priority Priority
        {
            get => JavaObject.getPriority();
            set => JavaObject.setPriority(value);
        }

        public string Project
        {
            get => JavaObject.getProject();
            set => JavaObject.setProject(value);
        }

        public java.lang.Number RemainingCost
        {
            get => JavaObject.getRemainingCost();
            set => JavaObject.setRemainingCost(value);
        }

        public net.sf.mpxj.Duration RemainingDuration
        {
            get => JavaObject.getRemainingDuration();
            set => JavaObject.setRemainingDuration(value);
        }

        public net.sf.mpxj.Duration RemainingWork
        {
            get => JavaObject.getRemainingWork();
            set => JavaObject.setRemainingWork(value);
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

        public void SetStart(int index, java.time.LocalDateTime value)
        {
            JavaObject.setStart(index, value);
        }

        public java.time.LocalDateTime GetStart(int index)
        {
            return JavaObject.getStart(index);
        }

        public net.sf.mpxj.Duration StartVariance
        {
            get => JavaObject.getStartVariance();
            set => JavaObject.setStartVariance(value);
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

        public java.lang.Number SV
        {
            get => JavaObject.getSV();
            set => JavaObject.setSV(value);
        }

        public void SetText(int index, string value)
        {
            JavaObject.setText(index, value);
        }

        public string GetText(int index)
        {
            return JavaObject.getText(index);
        }

        public void SetOutlineCode(int index, string value)
        {
            JavaObject.setOutlineCode(index, value);
        }

        public string GetOutlineCode(int index)
        {
            return JavaObject.getOutlineCode(index);
        }

        public net.sf.mpxj.Duration TotalSlack
        {
            get => JavaObject.getTotalSlack();
            set => JavaObject.setTotalSlack(value);
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
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

        public net.sf.mpxj.Duration Work
        {
            get => JavaObject.getWork();
            set => JavaObject.setWork(value);
        }

        public net.sf.mpxj.Duration WorkVariance
        {
            get => JavaObject.getWorkVariance();
            set => JavaObject.setWorkVariance(value);
        }

        public Task ParentTask
        {
            get => Parent.ProxyObject(JavaObject.getParentTask());
        }

        public java.lang.Integer ParentTaskUniqueID
        {
            get => JavaObject.getParentTaskUniqueID();
        }

        public IList<Task> ChildTasks
        {
            get => Parent.ProxyTaskList(JavaObject.getChildTasks());
        }

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

        public net.sf.mpxj.TaskType Type
        {
            get => JavaObject.getType();
            set => JavaObject.setType(value);
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

        public java.lang.Integer SubprojectTaskUniqueID
        {
            get => JavaObject.getSubprojectTaskUniqueID();
            set => JavaObject.setSubprojectTaskUniqueID(value);
        }

        public java.lang.Integer SubprojectTaskID
        {
            get => JavaObject.getSubprojectTaskID();
            set => JavaObject.setSubprojectTaskID(value);
        }

        public java.lang.Integer SubprojectTasksUniqueIDOffset
        {
            get => JavaObject.getSubprojectTasksUniqueIDOffset();
            set => JavaObject.setSubprojectTasksUniqueIDOffset(value);
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

        public bool ExternalProject
        {
            get => JavaObject.getExternalProject();
        }

        public java.lang.Number ACWP
        {
            get => JavaObject.getACWP();
            set => JavaObject.setACWP(value);
        }

        public net.sf.mpxj.TimeUnit LevelingDelayFormat
        {
            get => JavaObject.getLevelingDelayFormat();
            set => JavaObject.setLevelingDelayFormat(value);
        }

        public bool IgnoreResourceCalendar
        {
            get => JavaObject.getIgnoreResourceCalendar();
            set => JavaObject.setIgnoreResourceCalendar(value);
        }

        public java.lang.Number PhysicalPercentComplete
        {
            get => JavaObject.getPhysicalPercentComplete();
            set => JavaObject.setPhysicalPercentComplete(value);
        }

        public net.sf.mpxj.EarnedValueMethod EarnedValueMethod
        {
            get => JavaObject.getEarnedValueMethod();
            set => JavaObject.setEarnedValueMethod(value);
        }

        public net.sf.mpxj.Duration ActualWorkProtected
        {
            get => JavaObject.getActualWorkProtected();
            set => JavaObject.setActualWorkProtected(value);
        }

        public net.sf.mpxj.Duration ActualOvertimeWorkProtected
        {
            get => JavaObject.getActualOvertimeWorkProtected();
            set => JavaObject.setActualOvertimeWorkProtected(value);
        }

        public net.sf.mpxj.Duration RegularWork
        {
            get => JavaObject.getRegularWork();
            set => JavaObject.setRegularWork(value);
        }

        public bool EffortDriven
        {
            get => JavaObject.getEffortDriven();
            set => JavaObject.setEffortDriven(value);
        }

        public java.time.LocalDateTime GetDate(int index)
        {
            return JavaObject.getDate(index);
        }

        public void SetDate(int index, java.time.LocalDateTime value)
        {
            JavaObject.setDate(index, value);
        }

        public java.lang.Number OvertimeCost
        {
            get => JavaObject.getOvertimeCost();
            set => JavaObject.setOvertimeCost(value);
        }

        public java.lang.Number ActualOvertimeCost
        {
            get => JavaObject.getActualOvertimeCost();
            set => JavaObject.setActualOvertimeCost(value);
        }

        public net.sf.mpxj.Duration ActualOvertimeWork
        {
            get => JavaObject.getActualOvertimeWork();
            set => JavaObject.setActualOvertimeWork(value);
        }

        public net.sf.mpxj.AccrueType FixedCostAccrual
        {
            get => JavaObject.getFixedCostAccrual();
            set => JavaObject.setFixedCostAccrual(value);
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

        public net.sf.mpxj.Duration OvertimeWork
        {
            get => JavaObject.getOvertimeWork();
            set => JavaObject.setOvertimeWork(value);
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

        public net.sf.mpxj.Duration RemainingOvertimeWork
        {
            get => JavaObject.getRemainingOvertimeWork();
            set => JavaObject.setRemainingOvertimeWork(value);
        }

        public java.lang.Number RemainingOvertimeCost
        {
            get => JavaObject.getRemainingOvertimeCost();
            set => JavaObject.setRemainingOvertimeCost(value);
        }

        public ProjectCalendar Calendar
        {
            get => Parent.ProxyObject(JavaObject.getCalendar());
            set => JavaObject.setCalendar(value.JavaObject);
        }

        public java.lang.Integer CalendarUniqueID
        {
            get => JavaObject.getCalendarUniqueID();
            set => JavaObject.setCalendarUniqueID(value);
        }

        public bool Expanded
        {
            get => JavaObject.getExpanded();
            set => JavaObject.setExpanded(value);
        }

        public net.sf.mpxj.Duration StartSlack
        {
            get => JavaObject.getStartSlack();
            set => JavaObject.setStartSlack(value);
        }

        public net.sf.mpxj.Duration FinishSlack
        {
            get => JavaObject.getFinishSlack();
            set => JavaObject.setFinishSlack(value);
        }

        public object GetFieldByAlias(string alias)
        {
            // TODO: proxy result
            return JavaObject.getFieldByAlias(alias);
        }

        public void SetFieldByAlias(string alias, object value)
        {
            // TODO proxy arg
            JavaObject.setFieldByAlias(alias, value);
        }

        public java.util.List Splits
        {
            get => JavaObject.getSplits();
            set => JavaObject.setSplits(value);
        }

        public void Remove()
        {
            JavaObject.remove();
        }

        public ProjectFile expandSubproject()
        {
            return Parent.ProxyObject(JavaObject.expandSubproject());
        }

        public ProjectFile SubprojectObject
        {
            get => Parent.ProxyObject(JavaObject.getSubprojectObject());
            set => JavaObject.setSubprojectObject(value.JavaObject);
        }

        public java.lang.Number GetEnterpriseCost(int index)
        {
            return JavaObject.getEnterpriseCost(index);
        }

        public void SetEnterpriseCost(int index, java.lang.Number value)
        {
            JavaObject.setEnterpriseCost(index, value);
        }

        public java.time.LocalDateTime GetEnterpriseDate(int index)
        {
            return JavaObject.getEnterpriseDate(index);
        }

        public void SetEnterpriseDate(int index, java.time.LocalDateTime value)
        {
            JavaObject.setEnterpriseDate(index, value);
        }

        public net.sf.mpxj.Duration GetEnterpriseDuration(int index)
        {
            return JavaObject.getEnterpriseDuration(index);
        }

        public void SetEnterpriseDuration(int index, net.sf.mpxj.Duration value)
        {
            JavaObject.setEnterpriseDuration(index, value);
        }

        public bool GetEnterpriseFlag(int index)
        {
            return JavaObject.getEnterpriseFlag(index);
        }

        public void SetEnterpriseFlag(int index, bool value)
        {
            JavaObject.setEnterpriseFlag(index, value);
        }

        public java.lang.Number GetEnterpriseNumber(int index)
        {
            return JavaObject.getEnterpriseNumber(index);
        }

        public void SetEnterpriseNumber(int index, java.lang.Number value)
        {
            JavaObject.setEnterpriseNumber(index, value);
        }

        public string GetEnterpriseText(int index)
        {
            return JavaObject.getEnterpriseText(index);
        }

        public void SetEnterpriseText(int index, string value)
        {
            JavaObject.setEnterpriseText(index, value);
        }

        public void SetBaselineCost(int baselineNumber, java.lang.Number value)
        {
            JavaObject.setBaselineCost(baselineNumber, value);
        }

        public void SetBaselineDuration(int baselineNumber, net.sf.mpxj.Duration value)
        {
            JavaObject.setBaselineDuration(baselineNumber, value);
        }

        public void SetBaselineFinish(int baselineNumber, java.time.LocalDateTime value)
        {
            JavaObject.setBaselineFinish(baselineNumber, value);
        }

        public void SetBaselineStart(int baselineNumber, java.time.LocalDateTime value)
        {
            JavaObject.setBaselineStart(baselineNumber, value); ;
        }

        public void SetBaselineWork(int baselineNumber, net.sf.mpxj.Duration value)
        {
            JavaObject.setBaselineWork(baselineNumber, value);
        }

        public java.lang.Number GetBaselineCost(int baselineNumber)
        {
            return JavaObject.getBaselineCost(baselineNumber);
        }

        public net.sf.mpxj.Duration GetBaselineDuration(int baselineNumber)
        {
            return JavaObject.getBaselineDuration(baselineNumber);
        }

        public string GetBaselineDurationText(int baselineNumber)
        {
            return JavaObject.getBaselineDurationText(baselineNumber);
        }

        public void SetBaselineDurationText(int baselineNumber, string value)
        {
            JavaObject.setBaselineDurationText(baselineNumber, value);
        }

        public java.time.LocalDateTime GetBaselineFinish(int baselineNumber)
        {
            return JavaObject.getBaselineFinish(baselineNumber);
        }

        public string GetBaselineFinishText(int baselineNumber)
        {
            return JavaObject.getBaselineFinishText(baselineNumber);
        }

        public void SetBaselineFinishText(int baselineNumber, string value)
        {
            JavaObject.setBaselineFinishText(baselineNumber, value);
        }

        public java.time.LocalDateTime GetBaselineStart(int baselineNumber)
        {
            return JavaObject.getBaselineStart(baselineNumber);
        }

        public string GetBaselineStartText(int baselineNumber)
        {
            return JavaObject.getBaselineStartText(baselineNumber);
        }

        public void SetBaselineStartText(int baselineNumber, string value)
        {
            JavaObject.setBaselineStartText(baselineNumber, value);
        }

        public net.sf.mpxj.Duration GetBaselineWork(int baselineNumber)
        {
            return JavaObject.getBaselineWork(baselineNumber);
        }

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

        public java.util.UUID GUID
        {
            get => JavaObject.getGUID();
            set => JavaObject.setGUID(value);
        }

        public net.sf.mpxj.TaskMode TaskMode
        {
            get => JavaObject.getTaskMode();
            set => JavaObject.setTaskMode(value);
        }

        public bool Active
        {
            get => JavaObject.getActive();
            set => JavaObject.setActive(value);
        }

        public net.sf.mpxj.Duration BaselineEstimatedDuration
        {
            get => JavaObject.getBaselineEstimatedDuration();
            set => JavaObject.setBaselineEstimatedDuration(value);
        }

        public void SetBaselineEstimatedDuration(int baselineNumber, net.sf.mpxj.Duration value)
        {
            JavaObject.setBaselineEstimatedDuration(baselineNumber, value);
        }

        public net.sf.mpxj.Duration GetBaselineEstimatedDuration(int baselineNumber)
        {
            return JavaObject.getBaselineEstimatedDuration(baselineNumber);
        }

        public java.time.LocalDateTime BaselineEstimatedStart
        {
            get => JavaObject.getBaselineEstimatedStart();
            set => JavaObject.setBaselineEstimatedStart(value);
        }

        public java.time.LocalDateTime GetBaselineEstimatedStart(int baselineNumber)
        {
            return JavaObject.getBaselineEstimatedStart(baselineNumber);
        }

        public void SetBaselineEstimatedStart(int baselineNumber, java.time.LocalDateTime value)
        {
            JavaObject.setBaselineEstimatedStart(baselineNumber, value);
        }

        public java.time.LocalDateTime BaselineEstimatedFinish
        {
            get => JavaObject.getBaselineEstimatedFinish();
            set => JavaObject.setBaselineEstimatedFinish(value);
        }

        public java.time.LocalDateTime GetBaselineEstimatedFinish(int baselineNumber)
        {
            return JavaObject.getBaselineEstimatedFinish(baselineNumber);
        }

        public void SetBaselineEstimatedFinish(int baselineNumber, java.time.LocalDateTime value)
        {
            JavaObject.setBaselineEstimatedFinish(baselineNumber, value);
        }

        public java.lang.Number BaselineFixedCost
        {
            get => JavaObject.getBaselineFixedCost();
            set => JavaObject.setBaselineFixedCost(value);
        }

        public void SetBaselineFixedCost(int baselineNumber, java.lang.Number value)
        {
            JavaObject.setBaselineFixedCost(baselineNumber, value);
        }

        public java.lang.Number GetBaselineFixedCost(int baselineNumber)
        {
            return JavaObject.getBaselineFixedCost(baselineNumber);
        }

        public net.sf.mpxj.AccrueType BaselineFixedCostAccrual
        {
            get => JavaObject.getBaselineFixedCostAccrual();
            set => JavaObject.setBaselineFixedCostAccrual(value);
        }

        public void SetBaselineFixedCostAccrual(int baselineNumber, net.sf.mpxj.AccrueType value)
        {
            JavaObject.setBaselineFixedCostAccrual(baselineNumber, value);
        }

        public net.sf.mpxj.AccrueType GetBaselineFixedCostAccrual(int baselineNumber)
        {
            return JavaObject.getBaselineFixedCostAccrual(baselineNumber);
        }

        public java.util.List ExpenseItems
        {
            get => JavaObject.getExpenseItems();
            set => JavaObject.setExpenseItems(value);
        }

        public java.lang.Number StoredMaterial
        {
            get => JavaObject.getStoredMaterial();
            set => JavaObject.setStoredMaterial(value);
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

        public java.lang.Integer WorkersPerDay
        {
            get => JavaObject.getWorkersPerDay();
            set => JavaObject.setWorkersPerDay(value);
        }

/* TODO: MPXJ 12.0.1
        public bool HammockCode
        {
            get => JavaObject.getHammockCode();
            set => JavaObject.setHammockCode(value);
        }
*/
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

        public java.lang.Number OverallPercentComplete
        {
            get => JavaObject.getOverallPercentComplete();
            set => JavaObject.setOverallPercentComplete(value);
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

        public net.sf.mpxj.Duration PlannedDuration
        {
            get => JavaObject.getPlannedDuration();
            set => JavaObject.setPlannedDuration(value);
        }

        public net.sf.mpxj.Duration PlannedWork
        {
            get => JavaObject.getPlannedWork();
            set => JavaObject.setPlannedWork(value);
        }

        public java.lang.Number PlannedCost
        {
            get => JavaObject.getPlannedCost();
            set => JavaObject.setPlannedCost(value);
        }

        public java.time.LocalDateTime SuspendDate
        {
            get => JavaObject.getSuspendDate();
            set => JavaObject.setSuspendDate(value);
        }

        public java.lang.Integer PrimaryResourceID
        {
            get => JavaObject.getPrimaryResourceID();
            set => JavaObject.setPrimaryResourceID(value);
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

        public net.sf.mpxj.PercentCompleteType PercentCompleteType
        {
            get => JavaObject.getPercentCompleteType();
            set => JavaObject.setPercentCompleteType(value);
        }

        public net.sf.mpxj.ActivityStatus ActivityStatus
        {
            get => JavaObject.getActivityStatus();
            set => JavaObject.setActivityStatus(value);
        }

        public net.sf.mpxj.ActivityType ActivityType
        {
            get => JavaObject.getActivityType();
            set => JavaObject.setActivityType(value);
        }

/* TODO MPXJ 12.0.1
        public bool LongestPath
        {
            get => JavaObject.getLongestPath();
            set => JavaObject.setLongestPath(value);
        }
*/
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

        public java.lang.Integer SprintID
        {
            get => JavaObject.getSprintID();
            set => JavaObject.setSprintID(value);
        }

        public java.lang.Integer BoardStatusID
        {
            get => JavaObject.getBoardStatusID();
            set => JavaObject.setBoardStatusID(value);
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

        public net.sf.mpxj.Duration ScheduledDuration
        {
            get => JavaObject.getScheduledDuration();
            set => JavaObject.setScheduledDuration(value);
        }

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

        public java.lang.Number GetBaselineBudgetCost(int baselineNumber)
        {
            return JavaObject.getBaselineBudgetCost(baselineNumber);
        }

        public void SetBaselineBudgetCost(int baselineNumber, java.lang.Number value)
        {
            JavaObject.setBaselineBudgetCost(baselineNumber, value);
        }

        public net.sf.mpxj.Duration GetBaselineBudgetWork(int baselineNumber)
        {
            return JavaObject.getBaselineBudgetWork(baselineNumber);
        }

        public void SetBaselineBudgetWork(int baselineNumber, net.sf.mpxj.Duration value)
        {
            JavaObject.setBaselineBudgetWork(baselineNumber, value);
        }

        public java.lang.Integer SequenceNumber
        {
            get => JavaObject.getSequenceNumber();
            set => JavaObject.setSequenceNumber(value);
        }

        public java.util.List Steps
        {
            get => JavaObject.getSteps();
            set => JavaObject.setSteps(value);
        }

        public java.lang.Integer LocationUniqueID
        {
            get => JavaObject.getLocationUniqueID();
            set => JavaObject.setLocationUniqueID(value);
        }

        public net.sf.mpxj.Location Location
        {
            get => JavaObject.getLocation();
            set => JavaObject.setLocation(value);
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

        public ProjectCalendar EffectiveCalendar
        {
            get => Parent.ProxyObject(JavaObject.getEffectiveCalendar());
        }

        public override string ToString()
        {
            return JavaObject.toString();
        }

        public bool IsPredecessor(Task task)
        {
            return JavaObject.isPredecessor(task.JavaObject);
        }

        public bool IsSucessor(Task task)
        {
            return JavaObject.isSucessor(task.JavaObject);
        }

        public bool HasChildTasks
        {
            get => JavaObject.hasChildTasks();
        }
    }
}