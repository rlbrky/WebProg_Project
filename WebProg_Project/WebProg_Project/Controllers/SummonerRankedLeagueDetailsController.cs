using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProg_Project.Data;
using WebProg_Project.Models;

namespace WebProg_Project.Controllers
{
    public class SummonerRankedLeagueDetailsController : Controller
    {
        private readonly WebProg_ProjectContext _context;

        public SummonerRankedLeagueDetailsController(WebProg_ProjectContext context)
        {
            _context = context;
        }

        // GET: SummonerRankedLeagueDetails
        public async Task<IActionResult> Index()
        {
            var webProg_ProjectContext = _context.SummonerRankedLeagueDetail.Include(s => s.Summoner);
            return View(await webProg_ProjectContext.ToListAsync());
        }

        // GET: SummonerRankedLeagueDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summonerRankedLeagueDetail = await _context.SummonerRankedLeagueDetail
                .Include(s => s.Summoner)
                .FirstOrDefaultAsync(m => m.LeagueId == id);
            if (summonerRankedLeagueDetail == null)
            {
                return NotFound();
            }

            return View(summonerRankedLeagueDetail);
        }

        // GET: SummonerRankedLeagueDetails/Create
        public IActionResult Create()
        {
            ViewData["SummonerId"] = new SelectList(_context.Summoner, "Id", "Id");
            return View();
        }

        // POST: SummonerRankedLeagueDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LeagueId,QueueType,Tier,Rank,SummonerId,LeaguePoint,Win,Losses,Veteran,Inactive,FreshBlood,HotStreak")] SummonerRankedLeagueDetail summonerRankedLeagueDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(summonerRankedLeagueDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SummonerId"] = new SelectList(_context.Summoner, "Id", "Id", summonerRankedLeagueDetail.SummonerId);
            return View(summonerRankedLeagueDetail);
        }

        // GET: SummonerRankedLeagueDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summonerRankedLeagueDetail = await _context.SummonerRankedLeagueDetail.FindAsync(id);
            if (summonerRankedLeagueDetail == null)
            {
                return NotFound();
            }
            ViewData["SummonerId"] = new SelectList(_context.Summoner, "Id", "Id", summonerRankedLeagueDetail.SummonerId);
            return View(summonerRankedLeagueDetail);
        }

        // POST: SummonerRankedLeagueDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LeagueId,QueueType,Tier,Rank,SummonerId,LeaguePoint,Win,Losses,Veteran,Inactive,FreshBlood,HotStreak")] SummonerRankedLeagueDetail summonerRankedLeagueDetail)
        {
            if (id != summonerRankedLeagueDetail.LeagueId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(summonerRankedLeagueDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SummonerRankedLeagueDetailExists(summonerRankedLeagueDetail.LeagueId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["SummonerId"] = new SelectList(_context.Summoner, "Id", "Id", summonerRankedLeagueDetail.SummonerId);
            return View(summonerRankedLeagueDetail);
        }

        // GET: SummonerRankedLeagueDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summonerRankedLeagueDetail = await _context.SummonerRankedLeagueDetail
                .Include(s => s.Summoner)
                .FirstOrDefaultAsync(m => m.LeagueId == id);
            if (summonerRankedLeagueDetail == null)
            {
                return NotFound();
            }

            return View(summonerRankedLeagueDetail);
        }

        // POST: SummonerRankedLeagueDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var summonerRankedLeagueDetail = await _context.SummonerRankedLeagueDetail.FindAsync(id);
            _context.SummonerRankedLeagueDetail.Remove(summonerRankedLeagueDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SummonerRankedLeagueDetailExists(string id)
        {
            return _context.SummonerRankedLeagueDetail.Any(e => e.LeagueId == id);
        }
    }
}
