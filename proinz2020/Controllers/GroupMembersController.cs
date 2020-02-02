﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proinz2020.Model;

namespace proinz2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupMembersController : ControllerBase
    {
        private readonly PSQLDbContext _context;

        public GroupMembersController(PSQLDbContext context)
        {
            _context = context;
        }

        // GET: api/GroupMembers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupMember>>> GetGroupMember()
        {
            return await _context.GroupMember.ToListAsync();
        }

        // GET: api/GroupMembers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupMember>> GetGroupMember(int id)
        {
            var groupMember = await _context.GroupMember.FindAsync(id);

            if (groupMember == null)
            {
                return NotFound();
            }

            return groupMember;
        }

        // PUT: api/GroupMembers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupMember(int id, GroupMember groupMember)
        {
            if (id != groupMember.Id)
            {
                return BadRequest();
            }

            _context.Entry(groupMember).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupMemberExists(id))
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

        // POST: api/GroupMembers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<GroupMember>> PostGroupMember(GroupMember groupMember)
        {
            _context.GroupMember.Add(groupMember);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGroupMember", new { id = groupMember.Id }, groupMember);
        }

        // DELETE: api/GroupMembers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GroupMember>> DeleteGroupMember(int id)
        {
            var groupMember = await _context.GroupMember.FindAsync(id);
            if (groupMember == null)
            {
                return NotFound();
            }

            _context.GroupMember.Remove(groupMember);
            await _context.SaveChangesAsync();

            return groupMember;
        }

        private bool GroupMemberExists(int id)
        {
            return _context.GroupMember.Any(e => e.Id == id);
        }
    }
}
