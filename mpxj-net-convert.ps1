$project_dir = "C:\Nexus\Application"
$files = Get-ChildItem -name $project_dir -Filter "*.cs" -Recurse


foreach ($file_name in $files) {
    $file = "$project_dir\$file_name"
        Write-Output "Processing $file"

    (gc $file) `
        -creplace 'using net\.sf\.mpxj;', 'using MPXJ.Net;' `
        -creplace 'using net\.sf\.mpxj.*', '' `
        -creplace 'net\.sf\.mpxj\.', 'MPXJ.Net.' `
        -creplace 'java\.time\.DayOfWeek', 'DayOfWeek' `
        -creplace 'DayOfWeek\.MONDAY', 'DayOfWeek.Monday' `
        -creplace 'DayOfWeek\.TUESDAY', 'DayOfWeek.Tuesday' `
        -creplace 'DayOfWeek\.WEDNESDAY', 'DayOfWeek.Wednesday' `
        -creplace 'DayOfWeek\.THURSDAY', 'DayOfWeek.Thursday' `
        -creplace 'DayOfWeek\.FRIDAY', 'DayOfWeek.Friday' `
        -creplace 'DayOfWeek\.SATURDAY', 'DayOfWeek.Saturday' `
        -creplace 'DayOfWeek\.SUNDAY', 'DayOfWeek.Sunday' `
        -creplace '\bFieldType\b', 'IFieldType' `
        -creplace '\bFieldContainer\b', 'IFieldContainer' `
        -creplace '\.ToIEnumerable<.+>\(\)', '' `
        -creplace '\.ToDateTime\(\)', '' `
        -creplace '\.ToNullableDateTime\(\)', '' `
        -creplace '\.ToNullableInt\(\)', '' `
        -creplace '\.ToGuid\(\)', '' `
        -creplace '\.ToInt\(\)', '' `
        -creplace '\.ToLong\(\)', '' `
        -creplace '\.ToDecimal\(\)', '' `
        -creplace '\.ToJavaInteger\(\)', '' `
        -creplace '\.ToJavaUUID\(\)', '' `
        -creplace '\.ToJavaLocalDateTime\(\)', '' `
        -creplace '\.ToJavaDate\(\)', '' `
        -creplace '\.ToJavaDouble\(\)', '' `
        -creplace '\.ToJavaLocalTime\(\)', '' `
        -creplace '\.floatValue\(\)', '' `
        -creplace 'Duration\.getInstance', 'Duration.GetInstance' `
        -creplace 'DataType\.STRING', 'DataType.String' `
        -creplace 'DataType\.NUMERIC', 'DataType.Numeric' `
        -creplace 'DataType\.DATE', 'DataType.Date' `
        -creplace 'DataType\.INTEGER', 'DataType.Integer' `
        -creplace 'DataType\.CURRENCY', 'DataType.Currency' `
        -creplace 'DataType\.BINARY', 'DataType.Binary' `
        -creplace 'DataType\.DURATION', 'DataType.Duration' `
        -creplace 'DataType\.BOOLEAN', 'DataType.Boolean' `
        -creplace 'DataType\.SHORT', 'DataType.Short' `
        -creplace 'FieldTypeClass\.ASSIGNMENT', 'FieldTypeClass.Assignment' `
        -creplace 'FieldTypeClass\.PROJECT', 'FieldTypeClass.Project' `
        -creplace 'FieldTypeClass\.RESOURCE', 'FieldTypeClass.Resource' `
        -creplace 'FieldTypeClass\.TASK', 'FieldTypeClass.Task' `
        -creplace 'ResourceType\.COST', 'ResourceType.Cost' `
        -creplace 'ResourceType\.WORK', 'ResourceType.Work' `
        -creplace 'ResourceType\.MATERIAL', 'ResourceType.Material' `
        -creplace 'ActivityType\.START_MILESTONE', 'ActivityType.StartMilestone' `
        -creplace 'ActivityType\.FINISH_MILESTONE', 'ActivityType.FinishMilestone' `
        -creplace 'ActivityType\.LEVEL_OF_EFFORT', 'ActivityType.LevelOfEffort' `
        -creplace 'ActivityType\.RESOURCE_DEPENDENT', 'ActivityType.ResourceDependent' `
        -creplace 'ActivityType\.TASK_DEPENDENT', 'ActivityType.TaskDependent' `
        -creplace 'ActivityType\.WBS_SUMMARY', 'ActivityType.WbsSummary' `
        -creplace 'ActivityType\.FINISH_FLAG', 'ActivityType.FinishFlag' `
        -creplace 'ActivityType\.START_FLAG', 'ActivityType.StartFlag' `
        -creplace 'ActivityType\.HAMMOCK', 'ActivityType.Hammock' `
        -creplace 'PercentCompleteType\.DURATION', 'PercentCompleteType.Duration' `
        -creplace 'PercentCompleteType\.PHYSICAL', 'PercentCompleteType.Physical' `
        -creplace 'PercentCompleteType\.SCOPE', 'PercentCompleteType.Scope' `
        -creplace 'PercentCompleteType\.UNITS', 'PercentCompleteType.Units' `
        -creplace 'ActivityStatus\.NOT_STARTED', 'ActivityStatus.NotStarted' `
        -creplace 'ActivityStatus\.IN_PROGRESS', 'ActivityStatus.InProgress' `
        -creplace 'ActivityStatus\.COMPLETED', 'ActivityStatus.Completed' `
        -creplace 'ConstraintType\.AS_SOON_AS_POSSIBLE', 'ConstraintType.AsSoonAsPossible' `
        -creplace 'ConstraintType\.AS_LATE_AS_POSSIBLE', 'ConstraintType.AsLateAsPossible' `
        -creplace 'ConstraintType\.MUST_START_ON', 'ConstraintType.MustStartOn' `
        -creplace 'ConstraintType\.MUST_FINISH_ON', 'ConstraintType.MustFinishOn' `
        -creplace 'ConstraintType\.START_NO_EARLIER_THAN', 'ConstraintType.StartNoEarlierThan' `
        -creplace 'ConstraintType\.START_NO_LATER_THAN', 'ConstraintType.StartNoLaterThan' `
        -creplace 'ConstraintType\.FINISH_NO_EARLIER_THAN', 'ConstraintType.FinishNoEarlierThan' `
        -creplace 'ConstraintType\.FINISH_NO_LATER_THAN', 'ConstraintType.FinishNoLaterThan' `
        -creplace 'ConstraintType\.START_ON', 'ConstraintType.StartOn' `
        -creplace 'ConstraintType\.FINISH_ON', 'ConstraintType.FinishOn' `
        -creplace 'RelationType\.START_START', 'RelationType.StartStart' `
        -creplace 'RelationType\.START_FINISH', 'RelationType.StartFinish' `
        -creplace 'RelationType\.FINISH_START', 'RelationType.FinishStart' `
        -creplace 'RelationType\.FINISH_FINISH', 'RelationType.FinishFinish' `
        -creplace 'RateSource\.RESOURCE', 'RateSource.Resource' `
        -creplace 'RateSource\.ROLE', 'RateSource.Role' `
        -creplace 'RateSource\.OVERRIDE', 'RateSource.Override' `
        -creplace 'AccrueType\.START', 'AccrueType.Start' `
        -creplace 'AccrueType\.PRORATED', 'AccrueType.Prorated' `
        -creplace 'AccrueType\.END', 'AccrueType.End' `
        -creplace 'ActivityCodeScope\.PROJECT', 'ActivityCodeScope.Project' `
        -creplace 'ActivityCodeScope\.EPS', 'ActivityCodeScope.Eps' `
        -creplace 'ActivityCodeScope\.GLOBAL', 'ActivityCodeScope.Global' `
        -creplace 'CalendarType\.GLOBAL', 'CalendarType.Global' `
        -creplace 'CalendarType\.PROJECT', 'CalendarType.Project' `
        -creplace 'CalendarType\.RESOURCE', 'CalendarType.Resource' `
        -creplace 'DayType\.DEFAULT', 'DayType.Default' `
        -creplace 'DayType\.WORKING', 'DayType.Working' `
        -creplace 'DayType\.NON_WORKING', 'DayType.NonWorking' `
        -creplace 'TimeUnit\.MINUTES', 'TimeUnit.Minutes' `
        -creplace 'TimeUnit\.HOURS', 'TimeUnit.Hours' `
        -creplace 'TimeUnit\.DAYS', 'TimeUnit.Days' `
        -creplace '\.ContourDefault', '.IsContourDefault' `
        -creplace 'LocalDateRange', 'DateOnlyRange' `
        -creplace 'LocalDateTimeHelper', 'DateTimeHelper' `
        -creplace 'LocalDateTimeRange', 'DateTimeRange' `
        -creplace 'LocalTimeRange', 'TimeOnlyRange' `
        | Out-File $file
}
