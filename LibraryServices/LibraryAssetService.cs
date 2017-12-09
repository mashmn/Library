using LibraryData;
using System;
using LibraryData.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LibraryServices
{
    public class LibraryAssetService : ILibraryAsset
    {
        private LibraryContext _context;

        public LibraryAssetService(LibraryContext context)
        {
            _context = context;
        }

        public void Add(LibraryAsset newAsset)
        {
            _context.Add(newAsset);
            _context.SaveChanges();
        }

        public LibraryAsset Get(int id)
        {
            return _context.LibraryAssets
                .Include(a => a.Status)
                .Include(a => a.Location)
                .FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets
                .Include(a => a.Status)
                .Include(a => a.Location);
        }

        public string GetAuthorOrDirector(int id)
        {
            throw new NotImplementedException();
        }

        public LibraryAsset GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            throw new NotImplementedException();
        }

        public string GetDeweyIndex(int id)
        {
            throw new NotImplementedException();
        }

        public string GetIsbn(int id)
        {
            throw new NotImplementedException();
        }

        public LibraryBranch GetLibraryCardByAssetId(int id)
        {
            throw new NotImplementedException();
        }

        public string GetTitle(int id)
        {
            throw new NotImplementedException();
        }

        public string GetType(int id)
        {
            throw new NotImplementedException();
        }
    }
}
