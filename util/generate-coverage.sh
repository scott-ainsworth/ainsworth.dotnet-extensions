#!/usr/bin/env bash
##
# Generate test coverage report
##
# re: https://medium.com/@nocgod/how-to-setup-your-dotnet-project-with-a-test-coverage-reporting-6ff1903f7240
# dotnet add package coverlet.collector
# dotnet add package coverlet.msbuild

# Preparation

# dotnet tool install -g dotnet-coverage
# dotnet tool install -g dotnet-reportgenerator-globaltool

set -o errexit
set -o nounset

# Cleanup and Rebuild

dotnet clean
dotnet build

# Execution

TEST_DIR="tests"
TEST_REPORTS_DIR="$TEST_DIR/reports"
COVERAGE_DIR="$TEST_DIR/coverage"
COVERAGE_REPORT_DIR="$COVERAGE_DIR/report"
COVERAGE_HISTORY_DIR="$COVERAGE_DIR/history"

mkdir -p $TEST_DIR $TEST_REPORTS_DIR
mkdir -p $COVERAGE_DIR $COVERAGE_REPORT_DIR $COVERAGE_HISTORY_DIR

dotnet test --collect:"XPlat Code Coverage" \
 	--logger "html;logfilename=test-report.html;verbosity=detailed"

# https://reportgenerator.io/usage
reportgenerator \
	-reports:"$TEST_REPORTS_DIR/*/*.xml" \
 	-targetdir:"$COVERAGE_REPORT_DIR" \
 	-reporttypes:"Html" \
 	-historydir:"$COVERAGE_HISTORY_DIR" \
 	-assemblyfilters:"-*.Tests.dll" \
 	-verbosity:"Warning" \
 	-title:"${PWD##*/}"
	#-sourcedirs:"src" \

# open tests/coverage/report/index.html

# end
