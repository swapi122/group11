




/*
'===============================================================================
'  LinqHelper.DAO.VaiTroTrongVuAnBase
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
	public class LqVaiTroTrongVuAnBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVaiTroTrongVuAnBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqVaiTroTrongVuAnEntity obj)
		{
			provider.GetTable<LqVaiTroTrongVuAnEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqVaiTroTrongVuAnEntity _obj)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqVaiTroTrongVuAnEntity tmp = q.First<LqVaiTroTrongVuAnEntity>();
			
			tmp.TenVaiTroTrongVuAn = _obj.TenVaiTroTrongVuAn;
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
		
		public void Delete(LqVaiTroTrongVuAnEntity obj)
		{
			provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenVaiTroTrongVuAn(string TenVaiTroTrongVuAn)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.TenVaiTroTrongVuAn == TenVaiTroTrongVuAn
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqVaiTroTrongVuAnEntity ob = (LqVaiTroTrongVuAnEntity)q.First<LqVaiTroTrongVuAnEntity>();
            provider.GetTable<LqVaiTroTrongVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqVaiTroTrongVuAnEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqVaiTroTrongVuAnEntity>();
		}

		public List<LqVaiTroTrongVuAnEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectByTenVaiTroTrongVuAn(string TenVaiTroTrongVuAn)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.TenVaiTroTrongVuAn == TenVaiTroTrongVuAn
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		public List<LqVaiTroTrongVuAnEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqVaiTroTrongVuAnEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqVaiTroTrongVuAnEntity>();
		}
		
		
		

	}
}
