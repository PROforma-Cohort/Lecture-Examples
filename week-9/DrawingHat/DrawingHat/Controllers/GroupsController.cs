using DrawingHat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DrawingHat.Controllers
{
    public class GroupsController : ApiController
    {

        public class CreateGroupViewModel
        {
            public string Name { get; set; }
            public int Size { get; set; }
        }

        [HttpPost]
        [Route("api/groups")]
        public IHttpActionResult CreateGroups([FromBody]CreateGroupViewModel data)
        {
            // divide the amount of people by group size
            // define group size
            // get all people
            using (var db = new HatContext())
            {
                var groupSize = data.Size;
                var people = db.People.OrderBy(o => Guid.NewGuid()).ToList();
                var rv = new List<Groups>();
                var loopTimes = people.Count / groupSize;
                // get the even groups
                var availibleStudents = new Queue<People>(people);

                for (int i = 0; i < loopTimes; i++)
                {
                    var newGroup = new Groups
                    {
                        Name = data.Name,
                        People = new List<People>()
                    };

                    for (int j = 0; j < groupSize; j++)
                    {
                        newGroup.People.Add(availibleStudents.Dequeue());
                    }
                    rv.Add(newGroup);
                }

                var pos = 0; 
                while (availibleStudents.Count > 0)
                {
                    if (pos >= rv.Count)
                    {
                        pos = 0;
                    }
                    rv[pos++].People.Add(availibleStudents.Dequeue());
                }

                return Ok(rv);
            }
        }

    }
}
