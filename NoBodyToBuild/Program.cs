﻿using System;
using System.Collections.Generic;

namespace NoBodyToBuild {
  public static class Program {
    public static void Main() {
      RunSampleA1();
      RunSampleA2();
      RunSampleB1();
      RunSampleB2();
      RunSampleC();
      RunSampleD();
      RunSampleE();
    }

    static void RunSampleA1() {
      var teamRockyId = new TeamId(1);
      var teamRocky = new SampleA1.Team(teamRockyId);
      var teamMemberTheHulkId = new TeamMemberId(2);
      var teamMemberTheHulk = new SampleA1.TeamMember(teamRockyId, teamMemberTheHulkId, new DateTime(2010, 1, 1));
      var teamRepository = new SampleA1.TeamRepository(new Dictionary<TeamId, SampleA1.Team> { { teamRockyId, teamRocky } });
      var teamMemberRepository = new SampleA1.TeamMemberRepository(new Dictionary<TeamMemberId, SampleA1.TeamMember> { { teamMemberTheHulkId, teamMemberTheHulk } });
      var service = new SampleA1.TeamApplicationService(teamRepository, teamMemberRepository);
      var request = new AppointChairmanRequest { TeamId = 1, TeamMemberId = 2 };
      try {
        service.When(request);
      }
      catch (InvalidOperationException) {}
      teamRocky.AddMember(teamMemberTheHulkId);
      service.When(request);
    }

    static void RunSampleA2() {
      var teamRockyId = new TeamId(1);
      var teamRocky = new SampleA2.Team(teamRockyId);
      var teamMemberTheHulkId = new TeamMemberId(2);
      var teamMemberTheHulk = new SampleA2.TeamMember(teamRockyId, teamMemberTheHulkId, new DateTime(2010, 1, 1));
      var teamRepository = new SampleA2.TeamRepository(new Dictionary<TeamId, SampleA2.Team> { { teamRockyId, teamRocky } });
      var teamMemberRepository = new SampleA2.TeamMemberRepository(new Dictionary<TeamMemberId, SampleA2.TeamMember> { { teamMemberTheHulkId, teamMemberTheHulk } });
      var service = new SampleA2.TeamApplicationService(teamRepository, teamMemberRepository);
      var request = new AppointChairmanRequest { TeamId = 1, TeamMemberId = 2 };
      try {
        service.When(request);
      } catch (InvalidOperationException) { }
      teamRocky.AddMember(teamMemberTheHulkId);
      service.When(request);
    }

    static void RunSampleB1() {
      var teamRockyId = new TeamId(1);
      var teamRocky = new SampleB1.Team(teamRockyId);
      var teamMemberTheHulkId = new TeamMemberId(2);
      var teamMemberTheHulk = new SampleB1.TeamMember(teamRockyId, teamMemberTheHulkId, new DateTime(2010, 1, 1));
      var teamRepository = new SampleB1.TeamRepository(new Dictionary<TeamId, SampleB1.Team> { { teamRockyId, teamRocky } });
      var teamMemberRepository = new SampleB1.TeamMemberRepository(new Dictionary<TeamMemberId, SampleB1.TeamMember> { { teamMemberTheHulkId, teamMemberTheHulk } });
      var service = new SampleB1.TeamApplicationService(teamRepository, teamMemberRepository);
      var request = new AppointChairmanRequest { TeamId = 1, TeamMemberId = 2 };
      service.When(request);
    }

    static void RunSampleB2() {
      var teamRockyId = new TeamId(1);
      var teamRocky = new SampleB2.Team(teamRockyId);
      var teamMemberTheHulkId = new TeamMemberId(2);
      var teamMemberTheHulk = new SampleB2.TeamMember(teamRockyId, teamMemberTheHulkId, new DateTime(2010, 1, 1));
      var teamRepository = new SampleB2.TeamRepository(new Dictionary<TeamId, SampleB2.Team> { { teamRockyId, teamRocky } });
      var teamMemberRepository = new SampleB2.TeamMemberRepository(new Dictionary<TeamMemberId, SampleB2.TeamMember> { { teamMemberTheHulkId, teamMemberTheHulk } });
      var service = new SampleB2.TeamApplicationService(teamRepository, teamMemberRepository);
      var request = new AppointChairmanRequest { TeamId = 1, TeamMemberId = 2 };
      service.When(request);
    }

    static void RunSampleC() {
      var teamRockyId = new TeamId(1);
      var teamRocky = new SampleC.Team(teamRockyId);
      var teamMemberTheHulkId = new TeamMemberId(2);
      var teamMemberTheHulk = new SampleC.TeamMember(teamRockyId, teamMemberTheHulkId, new DateTime(2010, 1, 1));
      var teamRepository = new SampleC.TeamRepository(new Dictionary<TeamId, SampleC.Team> { { teamRockyId, teamRocky } });
      var teamMemberRepository = new SampleC.TeamMemberRepository(new Dictionary<TeamMemberId, SampleC.TeamMember> { { teamMemberTheHulkId, teamMemberTheHulk } });
      var makeChairmanService = new SampleC.AppointChairmanService(teamRepository, teamMemberRepository);
      var service = new SampleC.TeamApplicationService(makeChairmanService);
      var request = new AppointChairmanRequest { TeamId = 1, TeamMemberId = 2 };
      service.When(request);
    }

    static void RunSampleD() {
      var teamRockyId = new TeamId(1);
      var teamRocky = new SampleD.Team(teamRockyId);
      var teamMemberTheHulkId = new TeamMemberId(2);
      var teamMemberTheHulk = new SampleD.TeamMember(teamRockyId, teamMemberTheHulkId, new DateTime(2010, 1, 1));
      var teamRepository = new SampleD.TeamRepository(new Dictionary<TeamId, SampleD.Team> { { teamRockyId, teamRocky } });
      var teamMemberRepository = new SampleD.TeamMemberRepository(new Dictionary<TeamMemberId, SampleD.TeamMember> { { teamMemberTheHulkId, teamMemberTheHulk } });
      var teamChairmanshipRepository = new SampleD.TeamChairmanshipRepository(new List<SampleD.TeamChairmanship>());
      var makeChairmanService = new SampleD.AppointChairmanService(teamRepository, teamMemberRepository, teamChairmanshipRepository);
      var service = new SampleD.TeamApplicationService(makeChairmanService);
      var request = new AppointChairmanRequest { TeamId = 1, TeamMemberId = 2 };
      service.When(request);
    }

    static void RunSampleE() {
      var teamRockyId = new TeamId(1);
      var teamRocky = new SampleE.Team(teamRockyId);
      var teamMemberTheHulkId = new TeamMemberId(2);
      var teamMemberTheHulk = new SampleE.TeamMember(teamRockyId, teamMemberTheHulkId, new DateTime(2010, 1, 1));
      var teamRepository = new SampleE.TeamRepository(new Dictionary<TeamId, SampleE.Team> { { teamRockyId, teamRocky } });
      var teamMemberRepository = new SampleE.TeamMemberRepository(new Dictionary<TeamMemberId, SampleE.TeamMember> { { teamMemberTheHulkId, teamMemberTheHulk } });
      var makeChairmanService = new SampleE.AppointChairmanService(teamRepository, teamMemberRepository);
      var service = new SampleE.TeamApplicationService(makeChairmanService);
      var request = new AppointChairmanRequest { TeamId = 1, TeamMemberId = 2 };
      service.When(request);
    }
  }
}
