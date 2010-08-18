




/*
'===============================================================================
'  LinqHelper.DAO.TinhTrangChinhTriBase
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
	public class LqTinhTrangChinhTriBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhTrangChinhTriBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTinhTrangChinhTriEntity obj)
		{
			provider.GetTable<LqTinhTrangChinhTriEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTinhTrangChinhTriEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTinhTrangChinhTriEntity tmp = q.First<LqTinhTrangChinhTriEntity>();
			
			tmp.TenTinhTrangChinhTri = _obj.TenTinhTrangChinhTri;
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
		
		public void Delete(LqTinhTrangChinhTriEntity obj)
		{
			provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTinhTrangChinhTri(string TenTinhTrangChinhTri)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.TenTinhTrangChinhTri == TenTinhTrangChinhTri
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTinhTrangChinhTriEntity ob = (LqTinhTrangChinhTriEntity)q.First<LqTinhTrangChinhTriEntity>();
            provider.GetTable<LqTinhTrangChinhTriEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTinhTrangChinhTriEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTinhTrangChinhTriEntity>();
		}

		public List<LqTinhTrangChinhTriEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectByTenTinhTrangChinhTri(string TenTinhTrangChinhTri)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.TenTinhTrangChinhTri == TenTinhTrangChinhTri
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		public List<LqTinhTrangChinhTriEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTinhTrangChinhTriEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTinhTrangChinhTriEntity>();
		}
		
		
		

	}
}
