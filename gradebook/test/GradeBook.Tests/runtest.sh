#!/bin/bash

dotnet test --settings:../codecoverage.runsettings --logger "trx;LogFileName=TestResults.trx" --logger "xunit;LogFileName=TestResults.xml" --results-directory ./BuildReports/UnitTests /p:CollectCoverage=true /p:CoverletOutput=BuildReports/Coverage/ /p:CoverletOutputFormat=cobertura /p:Include="[GradeBook.*]*" /p:Exclude=\"[.*Tests.*]*\"
dotnet reportgenerator "-reports:BuildReports/Coverage/coverage.cobertura.xml" "-targetdir:BuildReports/Coverage" -reporttypes:HTML
open -a "Google Chrome" BuildReports/Coverage/index.htm