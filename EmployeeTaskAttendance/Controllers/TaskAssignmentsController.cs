using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeTaskAttendance.Models;

namespace EmployeeTaskAttendance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskAssignmentsController : ControllerBase
    {
        private readonly EmployeeTaskAttendanceContext _context;

        public TaskAssignmentsController(EmployeeTaskAttendanceContext context)
        {
            _context = context;
        }

        // GET: api/TaskAssignments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskAssignment>>> GetTaskAssignments()
        {
            return await _context.TaskAssignments.ToListAsync();
        }

        // GET: api/TaskAssignments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskAssignment>> GetTaskAssignment(int id)
        {
            var taskAssignment = await _context.TaskAssignments.FindAsync(id);

            if (taskAssignment == null)
            {
                return NotFound();
            }

            return taskAssignment;
        }

        // POST: api/TaskAssignments
        [HttpPost]
        public async Task<ActionResult<TaskAssignment>> PostTaskAssignment(TaskAssignment taskAssignment)
        {
            _context.TaskAssignments.Add(taskAssignment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskAssignment", new { id = taskAssignment.TaskAssignmentId }, taskAssignment);
        }

        // PUT: api/TaskAssignments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskAssignment(int id, TaskAssignment taskAssignment)
        {
            if (id != taskAssignment.TaskAssignmentId)
            {
                return BadRequest();
            }

            _context.Entry(taskAssignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskAssignmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/TaskAssignments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskAssignment(int id)
        {
            var taskAssignment = await _context.TaskAssignments.FindAsync(id);
            if (taskAssignment == null)
            {
                return NotFound();
            }

            _context.TaskAssignments.Remove(taskAssignment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskAssignmentExists(int id)
        {
            return _context.TaskAssignments.Any(e => e.TaskAssignmentId == id);
        }
    }
}
