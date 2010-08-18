




/*
'===============================================================================
'  LinqHelper.DAO.PhuongThucThuDoanBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqPhuongThucThuDoanBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhuongThucThuDoanBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqPhuongThucThuDoanEntity obj)
		{
			provider.GetTable<LqPhuongThucThuDoanEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqPhuongThucThuDoanEntity _obj)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqPhuongThucThuDoanEntity tmp = q.First<LqPhuongThucThuDoanEntity>();
			
			tmp.TenPhuongThucThuDoan = _obj.TenPhuongThucThuDoan;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqPhuongThucThuDoanEntity obj)
		{
			provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenPhuongThucThuDoan(string TenPhuongThucThuDoan)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.TenPhuongThucThuDoan == TenPhuongThucThuDoan
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqPhuongThucThuDoanEntity ob = (LqPhuongThucThuDoanEntity)q.First<LqPhuongThucThuDoanEntity>();
            provider.GetTable<LqPhuongThucThuDoanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqPhuongThucThuDoanEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqPhuongThucThuDoanEntity>();
		}

		public List<LqPhuongThucThuDoanEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectByTenPhuongThucThuDoan(string TenPhuongThucThuDoan)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.TenPhuongThucThuDoan == TenPhuongThucThuDoan
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		public List<LqPhuongThucThuDoanEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqPhuongThucThuDoanEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqPhuongThucThuDoanEntity>();
		}
		
		
		

	}
}
