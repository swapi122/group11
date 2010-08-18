




/*
'===============================================================================
'  LinqHelper.DAO.KetQuaXuLyBase
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
	public class LqKetQuaXuLyBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqKetQuaXuLyBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqKetQuaXuLyEntity obj)
		{
			provider.GetTable<LqKetQuaXuLyEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqKetQuaXuLyEntity _obj)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqKetQuaXuLyEntity tmp = q.First<LqKetQuaXuLyEntity>();
			
			tmp.TenKetQuaXuLy = _obj.TenKetQuaXuLy;
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
		
		public void Delete(LqKetQuaXuLyEntity obj)
		{
			provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenKetQuaXuLy(string TenKetQuaXuLy)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.TenKetQuaXuLy == TenKetQuaXuLy
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqKetQuaXuLyEntity ob = (LqKetQuaXuLyEntity)q.First<LqKetQuaXuLyEntity>();
            provider.GetTable<LqKetQuaXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqKetQuaXuLyEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqKetQuaXuLyEntity>();
		}

		public List<LqKetQuaXuLyEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectByTenKetQuaXuLy(string TenKetQuaXuLy)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.TenKetQuaXuLy == TenKetQuaXuLy
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		public List<LqKetQuaXuLyEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqKetQuaXuLyEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqKetQuaXuLyEntity>();
		}
		
		
		

	}
}
